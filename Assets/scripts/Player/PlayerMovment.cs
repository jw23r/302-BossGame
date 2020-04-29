using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed = 5;
    public OrbitCam theCam;
    CharacterController body;
    static public float h;
    static public float v;
    public Transform leftFist;
    public Transform RightFist;
    bool left;
    bool right = true;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       h = Input.GetAxis("Horizontal");
       v =Input.GetAxis("Vertical");
        print(v);
        print(h);
        if(v != 0 && theCam != null)
        {
            Quaternion targetRot  = Quaternion.Euler(0, theCam.yaw, 0);
            transform.rotation = AnimMath.Dampen(transform.rotation, targetRot, .01f);
        }
        Vector3 moveDis = transform.forward * v * moveSpeed;
        moveDis += transform.right * h * moveSpeed;
        body.SimpleMove(moveDis);
    }

}
