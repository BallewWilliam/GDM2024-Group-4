using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour
{
    public void QuitButton()
    {
        Application.Quit();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Singleplayer_Versus");
    }
    public void multiplayerRestart()
    {
        SceneManager.LoadScene("Multiplayer_Versus");
    }
}
