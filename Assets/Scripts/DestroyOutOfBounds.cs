using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zBound = - 95;

    void Update()
    {
        transform.Translate(Vector3.back * 20 * Time.deltaTime);
        if (transform.position.z < zBound)
        {
            Destroy(gameObject);
        }

        if(transform.position.y < - 2)
        {
            Destroy(gameObject);
        }
    }
}
