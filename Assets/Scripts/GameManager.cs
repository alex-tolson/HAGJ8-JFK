using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void BeginGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void SceneToInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
