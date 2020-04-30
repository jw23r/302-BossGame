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

            BossController.time += Time.deltaTime;
          
            if (boss.CanSeeAttackTarget())
            {
                if (BossController.time <= .5f)
                {
                    boss.wasteFront.transform.Rotate(Vector3.right* boss.speed * Time.deltaTime);
                    boss.wasteBack.transform.Rotate(Vector3.right * boss.speed * Time.deltaTime);


                    boss.MoveToTaregt(boss.tail, boss.coilTail,25);
                }
                else
                {
                    boss.wasteFront.transform.Rotate(-Vector3.right * boss.speed * Time.deltaTime);
                    boss.wasteBack.transform.Rotate(-Vector3.right * boss.speed * Time.deltaTime);

                    boss.MoveToTaregt(boss.tail, BossController.attackTarget, 25);
                }
              
            }
            if (BossController.time > 1f)
            {
                BossController.time = 0;
                return new BossReturnBodyPartsToRest();
            }
            return null;



        }
    }
}