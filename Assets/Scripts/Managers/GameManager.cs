using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject spawnManager;
    [HideInInspector]
    public GameObject restartButton;
    [HideInInspector]
    public GameObject startButton;
    [HideInInspector]
    public GameObject passText;
    public enum GameStates
    {
        GameStart,
        GameInGame,
        GameOver,
        GameNext
    }

    public GameStates currentState;

    public enum Panels
    {
        StartP,
        InGameP,
        GameOverP,
        PassLevelP
    }

       
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }else
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {
        currentState = GameStates.GameStart;
    }
    void Update()
    {
        switch(currentState)
        {
            case GameStates.GameStart: GameStart();
                break;
            case GameStates.GameInGame: GameInGame();
                break;
            case GameStates.GameOver: GameOver();
                break;
            case GameStates.GameNext: GameNext();
                break;
        }
    }

    private void GameStart()
    {
        spawnManager.SetActive(false);
        passText.SetActive(false);
        restartButton.SetActive(false);
        startButton.SetActive(true);
    }

    private void GameInGame()
    {
        spawnManager.SetActive(true);
        startButton.SetActive(false);
    }

    private void GameOver()
    {
        Debug.Log("Game is Over!");
        restartButton.SetActive(true);
    }
    private void GameNext()
    {
        passText.SetActive(true);
    }

    public void Starting()
    {
        currentState = GameStates.GameInGame;
    }
   
}
