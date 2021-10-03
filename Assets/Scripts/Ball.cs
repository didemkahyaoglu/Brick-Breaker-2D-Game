using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f ;
    [SerializeField] float yPush = 15f ;

    // Start is called before the first frame update

    Vector2 paddleToBall;
    bool hasStarted = false;


    void Start()
    {
      paddleToBall = transform.position - paddle.transform.position ;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            lockBalltoPaddle();
            mouseClick();
        }
    }

    private void lockBalltoPaddle()
    {
        Vector2 pedalPoz = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
         transform.position = pedalPoz + paddleToBall ;
        //transform.position = pedalPoz;
    }
    private void mouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }
}
