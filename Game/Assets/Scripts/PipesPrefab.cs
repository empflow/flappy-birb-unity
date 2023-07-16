using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesPrefab : MonoBehaviour
{
    private static AudioSource collisionSoundSrc;

    private void Start()
    {
        collisionSoundSrc = GetComponent<AudioSource>();
    }

    public void playCollisionSound()
    {
        collisionSoundSrc.Play();
    }
}
