using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    private void Awake()
    {
        MakeSingleton();
    }

    void MakeSingleton()
    {
        if(gameManager != null)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public event Action onNextSceneEnter;
    public void NextSceneEnter()
    {
        if (onNextSceneEnter != null)
        {
            onNextSceneEnter();
        }
    }

    public event Action onExitEnter;
    public void ExitEnter()
    {
        if (onExitEnter != null)
        {
            onExitEnter();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            NextSceneEnter();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitEnter();
        }
    }
}
