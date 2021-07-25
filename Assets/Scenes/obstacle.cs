using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    bool sw = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (sw == false)
        {
            float newXposition = transform.localPosition.x - 0.05f;
            transform.localPosition = new Vector3(newXposition, -4, 8);

        }
        else
        {
            float newXposition = transform.localPosition.x + 0.05f;
            transform.localPosition = new Vector3(newXposition, -4, 8);
        }
        if (transform.localPosition.x < -3.5)
        {
            sw = true;
        }
        if (transform.localPosition.x > 3.5)
        {
            sw = false;
        }
    }
}
