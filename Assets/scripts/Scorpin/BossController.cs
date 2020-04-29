using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb
{
    /// <summary>
    /// this bosss
    /// this is the main script on the boss and is where the main update will be overrided
    /// holds all functions that the other scripts will need to acces
    /// </summary>
    public class BossController : MonoBehaviour
    {
       public Transform attackTarget;

         static public bool canSee;
         public Transform rightArm;
         public Transform leftArm;
         public Transform tail;
         public float sightDis;
        [HideInInspector]// hides properties from inspector while leaving them accesible to other scripts

        BossState currentState;// keps track of what script boss is runing


        // gets the attack target and makes so it cant change
        // Start is called before the first frame update
        /// <summary>
        /// finds the player and then if the player was null it sets it to player 
        /// </summary>
        void Start()
        {



        }

        // Update is called once per frame
        /// <summary>
        /// switchs the state into another script
        /// if null will go to bossstate idel
        /// allows for swithcing states
        /// </summary>
        void Update()
        {
            if (currentState == null) SwitchToState(new BossStateIdel());
            if (currentState != null) SwitchToState(currentState.Update(this));


        }
        /// <summary>
        /// used for swithcing states
        /// </summary>
        /// <param name="newState"></param> used for calling functions from this script
        private void SwitchToState(BossState newState)
        {
            if (newState != null)
            {
                if (currentState != null) currentState.OnEnd(this);

                currentState = newState;
                currentState.OnStart(this);
            }
        }
        public void ItWorks()
        {
            print(canSee);
            print(transform.position.magnitude - attackTarget.position.magnitude);
            print("it works mother fucker");
        }
        public void CanSee(){
            if (transform.position.magnitude - attackTarget.position.magnitude > sightDis)
            {
                canSee = true;
            }
            else
            {
                canSee = false;
            }
            }
       public void MoveToTaregt(Vector3 target, int speed)
        {
            if (transform.position.magnitude - attackTarget.position.magnitude > sightDis)
            {
                Vector3 targetDirection = attackTarget.position - transform.position;

                // The step size is equal to speed times frame time.
                float singleStep = speed * Time.deltaTime;

                // Rotate the forward vector towards the target direction by one step
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);



                // Calculate a rotation a step closer to the target and applies rotation to this object
                transform.rotation = Quaternion.LookRotation(newDirection);
                tail.position = Vector3.MoveTowards(target, attackTarget.position, singleStep);
            }
        }
    }

}
    
