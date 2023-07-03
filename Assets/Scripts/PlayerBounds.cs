using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float rightBound = 5;
    private float leftBound = -9;

    void Update()
    {
        if (transform.position.x >= rightBound)
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);

        if (transform.position.x <= leftBound)
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
    }
}
