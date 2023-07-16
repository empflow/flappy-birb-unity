using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMoveScript : MonoBehaviour
{
    private GameManager gameManager;
    private float moveSpeed;
    public float deadZoneX;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        moveSpeed = gameManager.objectsSpeed;
    }

    void Update()
    {
        if (transform.position.x <= deadZoneX)
        {
            Destroy(gameObject);
        }

        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
