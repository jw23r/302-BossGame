using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongSpline : MonoBehaviour
{
    // Start is called before the first frame update
    public BezierCurve curve;
    [Range(0, 1)] public float percent = 0;

    public AnimationCurve speed;
    public float animationLength = 50;
    public bool shouldAnimate = true;
    float timeCurrent = 0;
    void Update()
    {
        if (shouldAnimate)
        {
           

            timeCurrent += Time.deltaTime;
            percent = timeCurrent / animationLength;
            percent = Mathf.Clamp(percent, 0, 1);
            print(percent);
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
            float p = speed.Evaluate(percent);
           
            transform.position = curve.FindPositionAt(p);

        }
    }
}