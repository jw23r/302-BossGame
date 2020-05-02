using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time < 0) Destroy(transform.parent.gameObject);


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Enemy" )
        {
            GUIController.enemeyHelath -= 8;
        }
        print("whats up");
        Destroy(transform.parent.gameObject);
    }
}
