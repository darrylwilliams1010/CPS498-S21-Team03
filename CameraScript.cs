/* Author: Darryl Williams 
 * About: moving script for the main camera
 * This allows user to rotate the camera 
 * with WASD keys
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speedH = 2.0f; // speed for the horizontal rotation
    public float speedV = 2.0f; // speed for vertical rotation
    private float yaw = 0.0f; // place holder for horizontal input 
    private float pitch = 0.0f; // place holder for vertical input
    


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Horizontal"); // gets input of horizontal keys 
        pitch -= speedV * Input.GetAxis("Vertical"); // gets input of vertical keys

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); // set the inputs of both yaw and pitch
    }
}

