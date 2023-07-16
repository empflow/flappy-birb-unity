using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject ground;
    public float spawnRate;

    void Start()
    {
        spawnInitGround();
    }

    public void spawnGround()
    {
        Vector3 pos = new Vector3(transform.position.x - 5, transform.position.y, 0);
        Instantiate(ground, pos, transform.rotation);
    }

    void spawnInitGround()
    {
        float groundHorizontalLength = 205.30f;
        Vector3 pos = new Vector3(transform.position.x - groundHorizontalLength, transform.position.y, 0);
        Instantiate(ground, pos, transform.rotation);
    }
}
