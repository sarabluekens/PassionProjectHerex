using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //
    public Transform player;

    //offset tussen player en camera
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //berekent de positie voor de camera adhv de positie van de player
        Vector3 cameraPosition = new Vector3(transform.position.x, transform.position.y, offset.z + player.position.z);
        transform.position = Vector3.Lerp(transform.position, cameraPosition, 10 *Time.deltaTime);
    }
}
