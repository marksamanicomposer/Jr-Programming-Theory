using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 20;
    private float maxRotation = 5;
    private float turnSpeed = 75;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime, Space.World);
        if (horizontalInput != 0)
            if (transform.rotation.y < maxRotation)
                if (transform.position.x <= 5 || transform.position.x >= -10)
                    transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        if (transform.rotation.y != 0)
            transform.rotation = new Quaternion(transform.rotation.x, Mathf.Lerp(transform.rotation.y, 0, Time.deltaTime * 2), transform.rotation.z, transform.rotation.w);

        if (horizontalInput == 0)
            if (transform.position.x != 2)
                transform.position = new Vector3(Mathf.Lerp(transform.position.x, -2, Time.deltaTime), transform.position.y, transform.position.z);

    }
}