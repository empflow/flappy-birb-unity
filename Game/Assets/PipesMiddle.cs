using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMiddleScript : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gameManager.incrementScore();
        }
    }
}
