using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject bird;
    public GameObject explosion;

    [Header("Score")]
    private int score = 0;
    public string scoreTextBase;
    public Text scoreText;

    [Header("Lives Left")]
    public int livesLeft;
    public int initLives;
    public string livesLeftTextBase;
    public Text livesLeftText;
    public bool hasLost = false;

    [Header("Objects speed")]
    public float objectsSpeed;

    [Header("Game Over")]
    public GameObject gameOverScreen;
    public Text gameOverScreenScoreText;
    public string gameOverScreenScoreTextBase;

    [Header("Sounds")]
    private AudioSource loudExplosionSrc;



    private void Start()
    {
        loudExplosionSrc = GetComponent<AudioSource>();
        updateLivesLeft(initLives);
        updateScore(score);
    }

    private void Update()
    {
        if (livesLeft == 0 && !hasLost)
        {
            gameOver();
        }
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
    }

    public void decrementLivesLeft()
    {
        if (hasLost) return;
        updateLivesLeft(livesLeft - 1);
    }

    public void gameOver()
    {
        Vector3 birdPos = bird.transform.position;
        Instantiate(explosion, birdPos, Quaternion.identity);
        updateLivesLeft(0);
        loudExplosionSrc.Play();
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
