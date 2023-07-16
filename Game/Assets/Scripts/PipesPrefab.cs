using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPrefab : MonoBehaviour
{
    public static AudioSource collisionSfSrc;

    private void Start()
    {
        collisionSfSrc = GetComponent<AudioSource>();
    }

    public void playCollisionSf()
    {
        collisionSfSrc.Play();
    }
}
