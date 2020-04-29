using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ProcedualWalksAnimation : MonoBehaviour
{
    public float sinWaveOffeset = 0;
    public float sinWaveSpeed = 4;
    


    public float scaleX = 1;
    public float distanceY = 1;
    public float distanceZ = 1;
    Vector3 startingPos;
    Vector3 finalPos;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {if (PlayerMovment.v * PlayerMovment.v > 0 || PlayerMovment.h * PlayerMovment.h > 0)
        {
            float time = (Time.time + sinWaveOffeset * Mathf.PI) * sinWaveSpeed;
            float offsetY = Mathf.Cos(time);
            float offsetZ = Mathf.Sin(time);
             finalPos = startingPos * scaleX;
            finalPos.y = offsetY * distanceY;
            finalPos.z = offsetZ * distanceZ;
            if (offsetY < 0) offsetY = 0;
            transform.localPosition = finalPos;
        }
    else
        {
            transform.localPosition = startingPos;

        }
    }
}
