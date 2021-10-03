using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadAScene()
    {
        int myCurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(myCurrentSceneIndex + 1);
    }
    public void StartOver()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
