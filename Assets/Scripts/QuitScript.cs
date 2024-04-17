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
        SceneManager.LoadScene("C_Damage");
    }
    public void multiplayerRestart()
    {
        SceneManager.LoadScene("C_Multiplayer");
    }
}
