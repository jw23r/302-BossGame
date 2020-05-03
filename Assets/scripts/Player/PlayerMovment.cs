using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

  
    public float sinWaveSpeed = 3;

    public Transform restingRightArm;
    public Transform restingLeftArm;



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
    public Transform Waste;

    public float legScaleX;
    public float legDistanceY;
    public float legDistanceZ;


    Vector3 input;

    
    float time;

    public float moveSpeed = 5;
    public OrbitCam theCam;
    CharacterController body;
    static public float h;
    static public float v;
    public Transform leftFist;
    public Transform rightFist;
    public Transform fistTargetRight;
    public Transform fistTargetLeft;

    public Transform rightleg;
    public Transform LeftLeg;
    bool left = true;
    bool right = true;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Transform projctileSpawn;
    public GameObject projectile;
    public float ideltime;
    public float deadTime;
   

    public Vector3 walkDir { get; private set;}

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
            time -= Time.deltaTime;
        if (GUIController.playerHealth <= 0)
        {
            deadTime -= Time.deltaTime;
            if (deadTime > 0)
            {
                transform.Rotate(-Vector3.right * 40 * Time.deltaTime);
            }
            }
            if (GUIController.playerHealth >= .1f)
        {
            ideltime -= Time.deltaTime;
            if (ideltime <= 0)
            {
                if (ideltime >= -1f)
                {
                    Waste.localPosition -= new Vector3(.2f, .2f, .2f);
                }
                if (ideltime <= -1.1f)
                {
                    Waste.localPosition += new Vector3(.2f, .2f, .2f);

                }
                if (ideltime < -2.2f)
                {
                    ideltime = 0;
                }

            }

            Move();
            walking(LeftLeg, 0, startingPosLeftLeg, legScaleX, legDistanceY, legDistanceZ);
            walking(rightleg, 1, startingPosRightLeg, legScaleX, legDistanceY, legDistanceZ);


            Punch();
            if (time < 0)
            {
                walking(rightFist, 1, startingPosRightFist, armScaleX, armDistanceY, armDistanceZ);
                walking(leftFist, 0, startingPosLeftFist, armScaleX, armDistanceY, armDistanceZ);
            }
        }
    }
    private void Punch()
    {

        if (right && time > 0)
        {
            MoveToTaregt(rightFist, fistTargetRight, 250);

        }
        else
        {
            MoveToTaregt(rightFist, restingRightArm, 250);
        }
        if (left && time > 0)
        {
            MoveToTaregt(leftFist, fistTargetLeft, 2500);

        }
        else
        {
            MoveToTaregt(leftFist, restingLeftArm, 2500);
        }

        if ( Input.GetButtonDown("Fire1") || Input.GetAxis("Fire1") > 0  )
        {
            if (time <= 0)
            {
                Instantiate(projectile, projctileSpawn.position, projctileSpawn.rotation);
                time = 1f;
            }
           // ideltime = 3;

        }
        if (Input.GetButton("Shift") || Input.GetAxis("Shift") > 0 )
        {
            moveSpeed = 3f;

        }
        else
        {
            moveSpeed = 2;
        }

    }

    /// <summary>
    /// 
    /// </summary>
    private void Move()
    {
       // print(body.isGrounded);

        if (body.isGrounded)
        {

            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
           input = new Vector3(h, 0.0f, v);

            walkDir = input * moveSpeed;
            input *= moveSpeed;
            if (v != 0 && theCam != null)
            {
                Quaternion targetRot = Quaternion.Euler(0, theCam.yaw, 0);
                transform.rotation = AnimMath.Dampen(transform.rotation, targetRot, .01f);
            }
            if (Input.GetButton("Jump"))
            {
                Waste.localPosition -= new Vector3(0, 3, 0);
         //       Waste.localPosition -= new Vector3(0, 3, 0);
            }

                if (Input.GetButtonUp("Jump"))
            {

                
            
                  //  print("i jumped b");
                    input.y = jumpSpeed;
                    Waste.localPosition += new Vector3(0, 3, 0);
                
            }
        

        // if (input.sqrMagnitude > 1) input.Normalize();
       // walkDir = input * moveSpeed;
    }
        input.y -= gravity * Time.deltaTime;
        walkDir = input * moveSpeed;
        body.Move(walkDir  * Time.deltaTime);
        
    }
    /// <summary>
    /// this makes are arms movetowards a set taget
    /// </summary>
    /// <param name="fist">what fist we want to move</param>
    /// <param name="speed">how fast the fist moves</param>
    private void MoveToTaregt(Transform fist, Transform target,int speed)
    {

        float singleStep = speed * Time.deltaTime;


        fist.position = Vector3.MoveTowards(fist.position, target.position, singleStep);
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
     
    }
}



