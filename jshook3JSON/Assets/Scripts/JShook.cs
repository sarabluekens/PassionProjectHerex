using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JShook : MonoBehaviour
{
    public GameObject Sphere;
    private Text numberX;
    private Text numberY;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            makeBlue();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            makeRed();
        }
    }

    public void makeBlue()
    {
        var ball = Sphere.GetComponent<Renderer>();
        ball.material.SetColor("_Color", Color.blue);

    }
    public void makeRed()
    {
        var ball = Sphere.GetComponent<Renderer>();
        ball.material.SetColor("_Color", Color.red);

    }
    public void setnumberX(int number)
    {
        numberX.text = "X coo: " + number.ToString();
    }
    public void setnumberY(int number)
    {
        numberX.text = "Y coo: " + number.ToString();
    }
}
