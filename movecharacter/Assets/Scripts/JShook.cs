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
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        Left();
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        Right();
    }
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        Middle();
    }
}

public void Left()
{
    var ball = Sphere.GetComponent<Renderer>();
    ball.transform.position = new Vector3(-3, 0, 0);
    ball.material.SetColor("_Color", Color.blue);

    }
public void Right()
{

    var ball = Sphere.GetComponent<Renderer>();
    ball.transform.position = new Vector3(3, 0, 0);
    ball.material.SetColor("_Color", Color.red);
    }

public void Middle()
{
    var ball = Sphere.GetComponent<Renderer>();
    ball.transform.position = new Vector3(0, 0, 0);
    ball.material.SetColor("_Color", Color.yellow);
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
