using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightArm : MonoBehaviour
{
    [SerializeField] Transform rightArm = null;
    [SerializeField] float sensitivity = 3.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Quote))
        {
            rightArm.transform.Translate(Vector3.up * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightArm.transform.Translate(Vector2.right * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Period))
        {
            rightArm.transform.Translate(Vector3.down * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rightArm.transform.Translate(Vector2.left * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rightArm.transform.Translate(Vector3.forward * sensitivity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightArm.transform.Translate(Vector3.back * sensitivity * Time.deltaTime);
        }
    }
}
