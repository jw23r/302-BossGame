using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

  
    public float sinWaveSpeed = 3;



   
    Vector3 startingPosLeftLeg;
    Vector3 startingPosLeftFist;
    Vector3 startingPosRightFist;
    Vector3 startingPosRightLeg;
    public float walkingArmSpeed; 
    public float walkingLegSpeed;
    public float runingLegSpeed;
    public float runingArmSpeed;
    public float armScaleX;
    public float armDistanceY;
    public float armDistanceZ;


    public float legScaleX;
    public float legDistanceY;
    public float legDistanceZ;





    public float moveSpeed = 5;
    public OrbitCam theCam;
    CharacterController body;
    static public float h;
    static public float v;
    public Transform leftFist;
    public Transform rightFist;
    public Transform fistTarget;
    public Transform rightleg;
    public Transform LeftLeg;


    bool left;
    bool right = true;
    // Start is called before the first frame update
    void Start()
    {
        startingPosLeftLeg = LeftLeg.localPosition;
         startingPosLeftFist = leftFist.localPosition;
        startingPosRightFist = rightFist.localPosition;
        startingPosRightLeg = rightleg.localPosition;
        body = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        walking(LeftLeg,0, startingPosLeftLeg,legScaleX,legDistanceY,legDistanceZ);
        walking(leftFist, 0, startingPosLeftFist,armScaleX,armDistanceY,armDistanceZ);
        walking(rightleg, 1, startingPosRightLeg, legScaleX, legDistanceY, legDistanceZ);
        walking(rightFist, 1, startingPosRightFist, armScaleX, armDistanceY, armDistanceZ);


        if (Input.GetKey(KeyCode.Mouse0))
        {
            MoveToTaregt(rightFist,5);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            MoveToTaregt(leftFist, 5);
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
    public void walking(Transform bodyPart, float sinWaveOffeset, Vector3 startingPos ,float scaleX ,float distanceY, float distanceZ )
    {                                                                               


        if (PlayerMovment.v * PlayerMovment.v > 0 || PlayerMovment.h * PlayerMovment.h > 0)
        {
            Vector3 finalPos;
            float time = (Time.time + sinWaveOffeset * Mathf.PI) * sinWaveSpeed;
            float offsetY = Mathf.Cos(time);
            float offsetZ = Mathf.Sin(time);
            finalPos = startingPos * scaleX;
            finalPos.y = offsetY * distanceY;
            finalPos.z = offsetZ * distanceZ;
            if (offsetY < 0) offsetY = 0;
            bodyPart.localPosition = finalPos;
        }
        else
        {
            if (!Input.GetKey(KeyCode.Mouse0))
            {
                bodyPart.localPosition = startingPos;
            }

        }
    }
}



