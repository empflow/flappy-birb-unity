using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Score")]
    private int score = 0;
    public string scoreTextBase;
    public Text scoreText;

    [Header("Lives Left")]
    private int livesLeft;
    public int initLives;
    public string livesLeftTextBase;
    public Text livesLeftText;
    public bool hasLost = false;

    [Header("Game Over")]
    public GameObject gameOverScreen;
    public Text gameOverScreenScoreText;
    public string gameOverScreenScoreTextBase;



    private void Start()
    {
        updateLivesLeft(initLives);
        updateScore(score);
    }

    private void Update()
    {

    }

    public void updateScore(int newScore)
    {
        score = newScore;
        scoreText.text = scoreTextBase + score.ToString();
    }

    public void incrementScore()
    {
        if (hasLost) return;
        updateScore(score + 1);
    }

    public void updateLivesLeft(int newLivesLeft)
    {
        livesLeft = newLivesLeft;
        livesLeftText.text = livesLeftTextBase + livesLeft.ToString();
        if (livesLeft == 0)
        {
             gameOver();
        }
    }

    public void decrementLivesLeft()
    {
        if (hasLost) return;
        updateLivesLeft(livesLeft - 1);
    }

    public void gameOver()
    {
        hasLost = true;
        gameOverScreenScoreText.text = gameOverScreenScoreTextBase + score.ToString();
        gameOverScreen.SetActive(true);
    }

    [ContextMenu("restart game")]
    public void restartGame()
    {
        string initSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(initSceneName);
    }
}
