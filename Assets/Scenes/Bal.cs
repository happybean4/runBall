using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bal : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)

    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 500);
        }


    }



    
}
