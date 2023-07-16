using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHit : MonoBehaviour
{
    private GameManager gameManager;
    private PipesPrefab pipesPrefab;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        pipesPrefab = GameObject.FindGameObjectWithTag("PipesPrefab").GetComponent<PipesPrefab>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.decrementLivesLeft();
        if (!gameManager.hasLost)
        {
            pipesPrefab.playCollisionSound();
        }
    }
}
