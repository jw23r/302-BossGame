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
            float chase;
            chase = Random.Range(1, 10) + Random.Range(1, 10) + Random.Range(1, 10);
            
            BossController.time += Time.deltaTime;
            Vector3 vectorBetween = boss.VectorToAttackTarget();

      
            if (boss.CanSeeAttackTarget())
            {
               // boss.ItWorks();
               if (boss.chaseDis * boss.chaseDis < vectorBetween.sqrMagnitude )
                boss.MoveToTaregt(boss.me,boss.attackTarget, 1);
                if(BossController.time >= chase) {
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