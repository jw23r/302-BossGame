using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb
{
    public class BossStateChase : BossState
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



            if (boss.CanSeeAttackTarget())
            {

                
            }

            return null;



        }
    }