using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float spawnNewGroundAtX;
    private float moveSpeed;
    private GameManager gameManager;
    private GroundSpawner groundSpawner;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        moveSpeed = gameManager.objectsSpeed;
        groundSpawner = GameObject.FindGameObjectWithTag("GroundSpawner").GetComponent<GroundSpawner>();
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!gameManager.hasLost)
        {
            gameManager.gameOver();
        }
    }
}
