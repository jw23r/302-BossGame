using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCam : MonoBehaviour
{
    public float distance = 5;
    Camera cam;
    public float scrollsensitivity = 1;
  

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var scroll = Input.mouseScrollDelta;
        distance += scroll.y * scrollsensitivity;
        distance = Mathf.Clamp(distance, 1, 10);
        Vector3 targetPos = new Vector3(0,0,-distance);
        cam.transform.localPosition = AnimMath.Dampen(cam.transform.localPosition, targetPos, .01f);
    }
}
