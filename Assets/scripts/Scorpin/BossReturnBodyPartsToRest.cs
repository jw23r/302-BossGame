using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb { 
public class BossReturnBodyPartsToRest : BossState
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

            BossController.time += Time.deltaTime;
            if (BossController.time < .3f)
            {
                boss.wasteFront.transform.Rotate(Vector3.right * boss.speed * Time.deltaTime);
                boss.wasteBack.transform.Rotate(Vector3.right * boss.speed * Time.deltaTime);
            }
            if (BossController.time <= .5f)
            {
                boss.MoveToTaregt(boss.tail, boss.tailRestPos, 25);
            }
            if (BossController.time > .5f)
            {
                    BossController.time = 0;
                return new BossStateIdel();
            }
        

        return null;



    }
}
}
