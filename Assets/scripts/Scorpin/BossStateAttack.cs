using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb
{

    public class BossStateAttack : BossState
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

            boss.ItWorks();

            if (boss.CanSeeAttackTarget())
            {
                boss.MoveToTaregt(boss.tail,15);  

            }

            return null;



        }
    }
}