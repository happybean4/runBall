using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation + ((-Input.GetAxis("Horizontal"))/2);
        transform.localEulerAngles = (new Vector3(12, 0, zRotation));
    }
}
