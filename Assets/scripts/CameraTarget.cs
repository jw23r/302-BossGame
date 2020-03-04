using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMe : MonoBehaviour
{

    // Start is called before the first frame update
    public Transform postionA;
    public Transform postionB;
     public float percent = 0.7f;
 
    public AnimationCurve curve;
    public float delayTimer;
    public float delayTarget;
    public float animationTime = 2;
    float animationTimeCurrent = 0;
    Vector3 currentEaseTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        delayTimer += Time.deltaTime;
       /* if (isPlayingFoward)
        {
animationTimeCurrent += Time.deltaTime;
            if (animationTimeCurrent > animationTime) isPlayingFoward = false;
        }
        else
        {
            animationTimeCurrent -= Time.deltaTime;
            if (animationTimeCurrent < 0) isPlayingFoward = true;
        }
       
        percent = animationTimeCurrent / animationTime;*/
        Calcposition();
      
    }
    void OnVailidate()
        {
        Calcposition();
    }
    /// <summary>
     /// this function calculates the final postion
     /// of this object between two sperate locations
     /// </summary>
    void Calcposition()
    {
        if (postionA == null) return;
        if (postionB == null) return;
        // transform.position = AnimiMath.Lerp(postionA.position, postionB.position, percent);
       float p = curve.Evaluate(percent);
        //find target postion
        if (delayTimer >= delayTarget)
        {
            currentEaseTarget = AnimMath.Lerp(postionA.position, postionB.position, p);
        }
        //ease twoard target
        transform.position = AnimMath.Dampen(transform.position,currentEaseTarget, .05f);
        //transform.position +=()
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(currentEaseTarget, Vector3.one* .1f);
    }
}
