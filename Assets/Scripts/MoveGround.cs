using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    private float speed = 20;
    private Vector3 startPos;
    private float repeatWidth = 20;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.z < startPos.z - repeatWidth)
            transform.position = startPos;
    }
}
