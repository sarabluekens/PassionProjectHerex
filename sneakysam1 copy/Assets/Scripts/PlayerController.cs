using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;

    //actieve baan baan  L = 0, M = 1, R = 2
    private int runlane = 1;

    // afstand tussen 2 banen
    private float laneDistance = 4;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        controller.Move(direction * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            runlane++;
            if(runlane == 3)
                runlane = 2;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            runlane--;
            if (runlane == -1)
                runlane = 0;

        }

        Vector3 targetPostition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(runlane == 0)
        {
            targetPostition += Vector3.left * laneDistance;
        }else if (runlane == 2)
        {
            targetPostition += Vector3.right * laneDistance;

        }
        transform.position = targetPostition;
    }
}
