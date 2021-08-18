using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{

 public void ReplayGame()
    {
        SceneManager.LoadScene("Game");
        ScoringSystem.theScore = 0;
    }

public void QuitGame()
    {
        Application.Quit();
    }
}
