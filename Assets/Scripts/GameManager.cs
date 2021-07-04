using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Singleton script responsible for firing off events that control game state; levels, score, quitting
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
        onNextSceneEnter?.Invoke();
    }

    public event Action onExitEnter;
    public void ExitEnter()
    {
        onExitEnter?.Invoke();
    }

    public event Action onScoreGoal;
    public void ScoreGoal(int teamNumber)
    {
        onScoreGoal?.Invoke();
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
