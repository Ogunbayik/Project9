using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [HideInInspector]
    public int[] boxScores;
    [HideInInspector]
    public Text desiredScoreText;
    [HideInInspector]
    public Text scoreText;
    [Header("Score Settings")]
    [SerializeField] private int minDesiredScore;
    [SerializeField] private int maxDesiredScore;

    private int score;
    private int desiredScore;
    

    private void Awake()
    {
        score = 0;
        desiredScore = Random.Range(minDesiredScore, maxDesiredScore);
    }
    void Start()
    {
        scoreText.text = "Score: " + score;
        desiredScoreText.text = desiredScore.ToString();
    }
    private void Update()
    {
        if(score == desiredScore)
        {
            GameManager.Instance.currentState = GameManager.GameStates.GameNext;
        }
        else if (score > desiredScore)
        {
            desiredScoreText.material.color = Color.red;
            GameManager.Instance.currentState = GameManager.GameStates.GameOver;
        }
    }

    private void OnEnable()
    {
        Boxes.OnBoxCollected1 += AddBox1;
        Boxes.OnBoxCollected2 += AddBox2;
        Boxes.OnBoxCollected3 += AddBox3;
        Boxes.OnBoxCollected4 += AddBox4;
        Boxes.OnBoxCollected5 += AddBox5;
        Boxes.OnBoxCollected6 += AddBox6;
        Boxes.OnBoxCollected7 += AddBox7;
        Boxes.OnBoxCollected8 += AddBox8;
        Boxes.OnBoxCollected9 += AddBox9;        
    }
    private void OnDisable()
    {
        Boxes.OnBoxCollected1 -= AddBox1;
        Boxes.OnBoxCollected2 -= AddBox2;
        Boxes.OnBoxCollected3 -= AddBox3;
        Boxes.OnBoxCollected4 -= AddBox4;
        Boxes.OnBoxCollected5 -= AddBox5;
        Boxes.OnBoxCollected6 -= AddBox6;
        Boxes.OnBoxCollected7 -= AddBox7;
        Boxes.OnBoxCollected8 -= AddBox8;
        Boxes.OnBoxCollected9 -= AddBox9;
    }

    #region AddBoxPoint
    void AddBox1()
    {
        score += boxScores[0];
        scoreText.text = "Score: " + score;
    }

    void AddBox2()
    {
        score += boxScores[1];
        scoreText.text = "Score: " + score;
    }

    void AddBox3()
    {
        score += boxScores[2];
        scoreText.text = "Score: " + score;
    }

    void AddBox4()
    {
        score += boxScores[3];
        scoreText.text = "Score: " + score;
    }

    void AddBox5()
    {
        score += boxScores[4];
        scoreText.text = "Score: " + score;
    }

    void AddBox6()
    {
        score += boxScores[5];
        scoreText.text = "Score: " + score;
    }

    void AddBox7()
    {
        score += boxScores[6];
        scoreText.text = "Score: " + score;
    }

    void AddBox8()
    {
        score += boxScores[7];
        scoreText.text = "Score: " + score;
    }

    void AddBox9()
    {
        score += boxScores[8];
        scoreText.text = "Score: " + score;
    }
    #endregion
}
