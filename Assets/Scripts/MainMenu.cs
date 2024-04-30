using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SingleplayerButton()
    {
        SceneManager.LoadScene("Singleplayer_Versus");
    }
    public void MultiplayerButton()
    {
        SceneManager.LoadScene("Multiplayer_Versus");
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
	}
}
