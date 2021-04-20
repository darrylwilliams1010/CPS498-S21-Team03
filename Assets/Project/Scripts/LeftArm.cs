using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArm : MonoBehaviour
{
    [SerializeField] Transform leftArm = null;
    [SerializeField] float sensitivity = 3.5f;

    // float pitch = 0.0f;
    // float yaw = 0.0f;
    // float roll = 0.0f;


    void Start()
    {
        
    }

    void Update()
    {
        Vector3 WASDDelta = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Input.GetAxis("Jump"));

        if (Input.GetKey(KeyCode.R))
        {
            leftArm.transform.Translate(Vector3.up * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            leftArm.transform.Translate(Vector2.right * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            leftArm.transform.Translate(Vector3.down * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            leftArm.transform.Translate(Vector2.left * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            leftArm.transform.Translate(Vector3.forward * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            leftArm.transform.Translate(Vector3.back * sensitivity * Time.deltaTime);
        }



    }
}
