using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{

    // Start is called before the first frame update
    public Transform target;
    
    public float percent = 0.7f;
    bool isPlayingFoward = true;
    public AnimationCurve curve;

    public float animationTime = 2;
   // float animationTimeCurrent = 0;
    Vector3 currentEaseTarget;
    void Start()
    {
        currentEaseTarget = target.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       
        
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
        
        // transform.position = AnimiMath.Lerp(postionA.position, postionB.position, percent);
       float p = curve.Evaluate(percent);
        //find target postion
      
        



        //ease twoard target
        transform.position = AnimMath.Dampen(transform.position,currentEaseTarget, .05f);
        //transform.position +=()
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(currentEaseTarget, Vector3.one* .1f);
    }
}
