using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody sphereRigidbody;
    public float speed;
   public Vector3 force = new Vector3(0, 0, 10);
    // Start is called before the first frame update
    void Start()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
        sphereRigidbody.AddForce(transform.forward * speed , ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
