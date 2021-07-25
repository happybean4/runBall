using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y + 5, ball.transform.position.z - 10);
    }
}
