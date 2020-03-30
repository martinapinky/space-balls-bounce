using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject ball;
    Vector3 ballPosition;
   
    // Start is called before the first frame update
    void Start()
    {
        ballPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ball != null)
        {
            ballPosition = ball.transform.position;
            this.transform.position = ballPosition;
        }
    }
}
