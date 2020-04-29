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
    public Transform rightFist;
    public Transform fistTarget;
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
        Move();
        MoveToTaregt(rightFist, 1);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            MoveToTaregt(rightFist,1);
        }
      
    }

    private void Move()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        
        if (v != 0 && theCam != null)
        {
            Quaternion targetRot = Quaternion.Euler(0, theCam.yaw, 0);
            transform.rotation = AnimMath.Dampen(transform.rotation, targetRot, .01f);
        }
        Vector3 moveDis = transform.forward * v * moveSpeed;
        moveDis += transform.right * h * moveSpeed;
        body.SimpleMove(moveDis);
    }
    private void MoveToTaregt(Transform fist, int speed)
    {

        float singleStep = speed * Time.deltaTime;


        fist.position = Vector3.MoveTowards(fist.position, fistTarget.position, singleStep);
    }
}



