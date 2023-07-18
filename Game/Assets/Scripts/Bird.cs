using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;

    private GameManager gameManager;


    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        bool isTouchingScreen = Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
        if (!gameManager.hasLost && (Input.GetKeyDown(KeyCode.Space)) || isTouchingScreen)
        {
            rb.velocity = Vector2.up * flapStrength;
        }
    }
}
