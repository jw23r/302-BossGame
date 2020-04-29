using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public Transform walkTarget;
    public Transform rightArm;
    public Transform leftArm;
    public Transform tail;
   
    public float speed = .01f;
    public float sightDis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTaregt(tail.position);
        MoveToTaregt(leftArm.position);
        MoveToTaregt(rightArm.position);
        MoveToTaregt(walkTarget.position);




    }

    private void MoveToTaregt(Vector3 target)
    {
        if (transform.position.magnitude - target.magnitude > sightDis) {
            Vector3 targetDirection = walkTarget.position - transform.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);



            // Calculate a rotation a step closer to the target and applies rotation to this object
            transform.rotation = Quaternion.LookRotation(newDirection);
            tail.position = Vector3.MoveTowards(target, walkTarget.position, singleStep);
        }
     }
}
