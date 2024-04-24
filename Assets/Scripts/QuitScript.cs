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
        SceneManager.LoadScene("C_Damage Art Scene");
    }
    public void multiplayerRestart()
    {
        SceneManager.LoadScene("Multiplayer_Versus");
    }
}
