using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAt : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) return;
        Vector3 look = target.position - transform.position;
        look.Normalize();
        // transform.rotation = Quaternion.LookRotation(look, Vector3.up);
        Quaternion targetRot = Quaternion.LookRotation(look, Vector3.up);
        transform.rotation = AnimMath.Lerp(transform.rotation, targetRot, 0.1f);
    }
}
