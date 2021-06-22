using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        GameManager.gameManager.onNextSceneEnter += LoadNextScene;
        GameManager.gameManager.onExitEnter += QuitGame;

    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        if (currentSceneIndex == sceneCount - 1)
        {
            LoadStartScene();
        }
        else
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }

    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnDestroy()
    {
        GameManager.gameManager.onNextSceneEnter -= LoadNextScene;
    }
}
