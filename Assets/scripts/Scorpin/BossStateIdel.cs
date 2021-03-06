﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb {
    /// <summary>
    /// this class makes the game object do nothing except look for the player and swtitches to prusue
    /// </summary>
    public class BossStateIdel : BossState
    {
        // Start is called before the first frame update
        /// <summary>
        /// overides current update
        /// checks to see enemy this stwithces states
        /// </summary>
        /// <param name="boss"></param>
        /// <returns></returns>
        public override BossState Update(BossController boss)
        {
            boss.IsDead();

            if (boss.dead == true)
            {
                return new BossStateDead();
            }
            if (!boss.dead)
            {
                Vector3 idel = new Vector3(0, .005f, .005f);
                BossController.time += Time.deltaTime;
                if (BossController.time < .5f)
                {
                    boss.transform.position -= idel;
                }
                if (BossController.time > .5f && BossController.time < 1.0f)
                {
                    boss.transform.position += idel;


                }
                if (BossController.time >= 1f)
                {
                    BossController.time = 0;
                }
                // boss.CanSeeAttackTarget();

                if (boss.CanSeeAttackTarget())
                {
                    //  boss.ItWorks();
                    return new BossStateChase();
                }
            }
            return null;



        }

        

       
    }
    }
