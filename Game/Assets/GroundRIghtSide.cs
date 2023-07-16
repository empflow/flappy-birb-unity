using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRIghtSide : MonoBehaviour
{
    private GroundSpawner groundSpawner;

    private void Start()
    {
        groundSpawner = GameObject.FindGameObjectWithTag("GroundSpawner").GetComponent<GroundSpawner>();
    }

    private void OnBecameVisible()
    {
        groundSpawner.spawnGround();
    }
}
