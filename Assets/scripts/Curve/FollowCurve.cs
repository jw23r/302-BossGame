using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCurve : MonoBehaviour
{   public BezierCurve curve;
    [Range(0, 1)] public float percent = 0;

    public AnimationCurve speed;
    public float animationLength = 5;
    public bool shouldAnimate = true;
    float timeCurrent = 0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
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
            float p = speed.Evaluate(percent);
            SetPostionToCurve();
            transform.position = curve.FindPositionAt(p);

        }
    }
}
