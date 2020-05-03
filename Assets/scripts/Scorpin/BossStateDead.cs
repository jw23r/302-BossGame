using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Webb
{
    public class BossStateDead : BossState
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
           
                boss.transform.Rotate(Vector3.forward * boss.speed * 2 * Time.deltaTime);
            
            
            boss.transform.localPosition += new Vector3(0, .02f, 0);
            return null;
        }

    }
}