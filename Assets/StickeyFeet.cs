using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickeyFeet : MonoBehaviour
{
    public StickeyFeet[] otherStickeyFeet;
    public Transform homeLocation;
    Vector3 plantedPosLast;
    Vector3 plantedPosNext;
    public float moveDistanceThreshold = .5f;
    public float timeToMoveFoot = 0.25f;
    float footMoveTimer = 0;
    [Header("footanimation:")]
    public AnimationCurve footlateralEase;
    public AnimationCurve footVerticalRaise;
    // Start is called before the first frame update
    void Start()
    {
        foreach (StickeyFeet )
        CheckIfCanMoveFoot();
        AnimatedFoot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AnimatedFoot()
    {

        if (footMoveTimer >= timeToMoveFoot)
        {
            
        
    transform.position = plantedPosNext;
            return;
        }
        footMoveTimer += Time.deltaTime;
        float p = footMoveTimer / timeToMoveFoot;
        p = Mathf.Clamp(p, 0, 1);
        Vector3 pos = Vector3.Lerp(plantedPosLast, plantedPosNext, footlateralEase.Evaluate(p));
        pos.y += footVerticalRaise .Evaluate(p);
        transform.position = pos;

    }
    void CheckIfCanMoveFoot()
    {
        float d2 = (transform.position - homeLocation.position).sqrMagnitude;
        if (d2 > moveDistanceThreshold * moveDistanceThreshold)
        {
            DoRaycast();
        }
    }
    void DoRaycast()
    {
        Ray ray = new Ray(homeLocation.position + Vector3.up * 2.5f, Vector3.down);
        if(Physics.Raycast(ray,out RaycastHit hit, 5))
        {
            footMoveTimer = 0;
            plantedPosLast = transform.position;
            plantedPosNext = hit.point;
        }
    }
    bool IsAnimating()
    {

    }
}
