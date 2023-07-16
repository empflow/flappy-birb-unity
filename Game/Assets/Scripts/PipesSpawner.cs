using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate;
    public float maxOffset;

    private float timer = 0;

    void Start()
    {
        spawnPipes();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipes();
            timer = 0;
        }
    }

    void spawnPipes()
    {
        float offset = Random.Range(-Mathf.Abs(maxOffset), Mathf.Abs(maxOffset));
        Vector3 pos = new Vector3(transform.position.x, offset, 0);
        Instantiate(pipes, pos, transform.rotation);
    }
}
