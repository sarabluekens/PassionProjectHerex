using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    private float forwardSpeed = 10;
    
    //actieve baan baan  L = 0, M = 1, R = 2
    private int runlane = 1;

    // afstand tussen 2 banen
    private float laneDistance = 2;


    //Jump
    public float jumpForce = 10;
    private float gravity = -20;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerManager.isGamestarted)
            return;
        forwardSpeed += 0.05f + Time.deltaTime;

        controller.Move(direction * Time.deltaTime);
        direction.z = forwardSpeed;

        // laat de character springen met gravity
        direction.y += gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            direction.y = -1;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }else
        {
            direction.y += gravity * Time.deltaTime;

        }




        // berekent de baan waar de player naartoe springt
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
        //

        
        Vector3 targetPostition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if(runlane == 0)
        {
            targetPostition += Vector3.left * laneDistance;
        }else if (runlane == 2)
        {
            targetPostition += Vector3.right * laneDistance;

        }
        
        transform.position = Vector3.Lerp(transform.position, targetPostition, 60 * Time.deltaTime) ;
        //controller.center = controller.center;
    }

    private void Jump()
    {
        direction.y = jumpForce;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.tag == "Obstacle")
        {
            PlayerManager.gameOver = true;
        }
    }
}
