using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SingleplayerButton()
    {
        SceneManager.LoadScene("C_Damage");
    }
    public void MultiplayerButton()
    {
        SceneManager.LoadScene("C_Multiplayer");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
	}
}
