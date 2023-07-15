using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMoveScript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZoneX;

    void Update()
    {
        if (transform.position.x <= deadZoneX)
        {
            Destroy(gameObject);
        }

        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
