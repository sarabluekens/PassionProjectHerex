﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private float speed = 15.0f;
  private float turnSpeed = 50;
  private float horizontalInput;
  private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
      // get player input
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");

        // move forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 

      // rotate vehicle
      transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);


    }
}
