using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] Transform playerCamera = null;
    [SerializeField] float mouseSensitivity = 3.5f;
    [SerializeField] bool lockCursor = true;

    float cameraPitch = 0.0f;
    float cameraYaw = 0.0f;

    void Start()
    {
        if(lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }

    void Update()
    {
        UpdateMouseLook();
    }
    
    void UpdateMouseLook()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        
        cameraPitch -= mouseDelta.y * mouseSensitivity;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);

        cameraYaw -= mouseDelta.x * mouseSensitivity;
        cameraYaw = Mathf.Clamp(cameraYaw, -45.0f, 45.0f);

        playerCamera.localEulerAngles = Vector3.right * cameraPitch;
        //playerCamera.localEulerAngles = Vector3.right * cameraYaw;

        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensitivity);
    }
}
