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

            
            BossController.time += Time.deltaTime;

            if (boss.CanSeeAttackTarget())
            {
               // boss.ItWorks();
                boss.MoveToTaregt(boss.me, 1);
                if(BossController.time >= 2) {
                    BossController.time = 0;
                    return new BossStateAttack();

                }
            }
            else
            {
                return new BossStateIdel();

            }

            return null;



        }
    }
}