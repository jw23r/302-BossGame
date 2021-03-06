﻿using System.Collections;
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
        public float speed;
        public Transform tailRestPos;
        public Transform coilTail;
        public float chaseDis;
    static public Transform attackTarget;
        public Transform me;
      static public float time;
         static public bool canSee;
         public Transform rightArm;
         public Transform leftArm;
         public Transform tail;
         public float sightDis;
        public Transform wasteFront;
        public Transform wasteBack;
        public Transform wasteBackOGRoatation;
        public Transform wasteFrontOGRoatation;
        public Transform wasteBackRoataiontarget;
        public Transform wasteFrontRoataiontarget;
        public Vector3 attackOffset = new Vector3(0,0,0);
       public  bool dead = false;


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
        public void IsDead()
        {
            if( GUIController.enemeyHelath <= 0)
            {
                dead = true;
            }
        }
        public void ItWorks()
        {
            print(canSee);
            print(transform.position.magnitude - attackTarget.position.magnitude);
            print("it works mother fucker");
        }
        public Vector3 VectorToAttackTarget()
        {

            return attackTarget.position - transform.position;
        }
        public float distanceToAttackTarget()
        {
            return VectorToAttackTarget().magnitude;
        }

        /// <summary>
        /// checks for wether or not the player is visble to the boss
        /// </summary>
        /// <returns></returns>
        public bool CanSeeAttackTarget()
        {
            if (attackTarget == null) return false;

            {
                Vector3 vectorBetween = VectorToAttackTarget();
             

                if (vectorBetween.sqrMagnitude < sightDis * sightDis)
                {
                    Vector3 offset = new Vector3(0, 1, 0);
                  //  return true;
                    //player is close enogue to boss to activate it
                    Vector3 dir = (attackTarget.position - transform.position).normalized;
                    Ray ray = new Ray(transform.position + offset, dir);
                    Debug.DrawRay(transform.position + offset, dir * sightDis, Color.green);
                    if (Physics.Raycast(ray, out RaycastHit hit,sightDis * sightDis))
                    {
                      //  print(hit);
                     
                        if (hit.transform == attackTarget) return true;
                        //clear line of vision


                        // if distances < thershold && raycast from player to boss hits..
                        // transtion to prsue

                    }
                }
            }
            return false;
        }
        
       public void MoveToTaregt(Transform bodyPart,Transform target, int speed)
        {
            if (attackTarget == null) return;
                Vector3 targetDirection = attackTarget.position - transform.position;

                // The step size is equal to speed times frame time.
                float singleStep = speed * Time.deltaTime;

                // Rotate the forward vector towards the target direction by one step
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection,  singleStep, 0.0f);



                // Calculate a rotation a step closer to the target and applies rotation to this object
                transform.rotation = Quaternion.LookRotation(newDirection);
            bodyPart.position = Vector3.MoveTowards(bodyPart.position, target.position, singleStep);
            }
        public void AttackTaregt(Transform bodyPart, Transform target, int speed)
        {

            Vector3 targetDirection = attackTarget.position - transform.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection , singleStep, 0.0f);



            // Calculate a rotation a step closer to the target and applies rotation to this object
            transform.rotation = Quaternion.LookRotation(newDirection);
            bodyPart.position = Vector3.MoveTowards(bodyPart.position, target.position + attackOffset, singleStep);
        }
        public void RotateTowards(Transform bodyPart,Transform target,int speed)
        {
            Vector3 targetDirection = target.position - bodyPart.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(bodyPart.forward, targetDirection, singleStep, 0.0f);
        }
        void OnTriggerEnter(Collider collider)
        {
            if (collider.transform.tag == "Player")
            {
                attackTarget = collider.transform;
               // print("u enter");
               // print(attackTarget);
            }
          
        }
        /// <summary>
        /// if enenmy has enemycontroller1 when it exits trigger it get removeds from array
        /// </summary>
        /// <param name="collider"></param>
        void OnTriggerExit(Collider collider)
        {

            if (collider.transform.tag == "Player")
            {
                //print("u leave");
               attackTarget = null;
               // print(attackTarget);
            }
            
        }
    }
}
    
    




    
