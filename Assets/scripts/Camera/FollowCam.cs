using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform veiwTarget;
    public Vector3 offset;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {

        transform.position = AnimMath.Dampen(transform.position, veiwTarget.position + offset, .01f);
    }
}
