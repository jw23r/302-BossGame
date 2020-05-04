﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCurve : MonoBehaviour
{   public BezierCurve curve;
    [Range(0, 1)] public float percent = 0;
    float p;
    public AnimationCurve speed;
    public float animationLength = 5;
    public bool shouldAnimate = true;
    float timeCurrent = 0;
    float time;
    public bool shake;
    // Start is called before the first frame update
    void Update()
    {
        time += Time.deltaTime;
        if (shouldAnimate)
        {
            timeCurrent += Time.deltaTime;
            percent = timeCurrent / animationLength;
            percent = Mathf.Clamp(percent, 0, 1);
        }
        SetPostionToCurve();
    }
    void OnValidate()
        {
        SetPostionToCurve();
        }
    private void SetPostionToCurve()
    {
        if (curve)
        {
            
            p = speed.Evaluate(percent);
            // print(p);
            if (p < 1)
            {
                transform.position = curve.FindPositionAt(p);

            }
            if (p >= 1 && shake)
            {
                if (time < .3f)
                {
                    transform.localPosition += new Vector3(0, .005f, .005f);
                }
                if(time > .4f && time < .8f )
                {
                    transform.localPosition += new Vector3(0, 0, -.005f);

                }
                if (time > .8f && time < 1.2f)
                {
                    transform.localPosition += new Vector3(0, -.005f, 0);

                }
                if (time > 1.2f && time < 1.5f)
                {
                    transform.localPosition += new Vector3(0, 0, .005f);

                }
                if (time >= 1.6f)
                {
                    time = 0;
                }
            }
        }
    }
}
