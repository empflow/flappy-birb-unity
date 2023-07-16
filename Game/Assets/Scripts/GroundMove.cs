using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float spawnNewGroundAtX;
    private float moveSpeed;
    private GameManager gameManager;
    private new Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        moveSpeed = gameManager.objectsSpeed;
    }

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
