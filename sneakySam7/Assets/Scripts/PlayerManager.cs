using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //static is global variable dat je kan accessen in andere scripts!
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject startingText;

    //startanimatie
    public static bool isGamestarted;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGamestarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
                
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGamestarted = true;
            Destroy(startingText);
        }
    }
}
