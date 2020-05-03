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
            boss.IsDead();

            if (boss.dead == true)
            {
                return new BossStateDead();
            }
            float chase;
            chase = Random.Range(1, 5) + Random.Range(1, 5) + Random.Range(1, 5);
            
            BossController.time += Time.deltaTime;
            Vector3 vectorBetween = boss.VectorToAttackTarget();

      
            if (boss.CanSeeAttackTarget())
            {
               // boss.ItWorks();
               if (boss.chaseDis * boss.chaseDis < vectorBetween.sqrMagnitude )
                boss.MoveToTaregt(boss.me,BossController.attackTarget, 4);
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