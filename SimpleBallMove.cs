using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBallMove : MonoBehaviour
{
    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;
    public Vector3 tempPosition;

    void Start()
    {
        tempPosition = transform.position;
    }

    void FixedUpdate()
    {
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup + verticalSpeed) * amplitude;
        transform.position = tempPosition;
    }
}
