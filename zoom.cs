/*Author: Darryl Williams
 * About: Zoom in script for the main camera
 * allows user to change the field of view with key inputs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    private Camera cam;    
    private float startingFOV;

    public float minFOV;  // limits how far user can zoom out
    public float maxFOV;   // limits how far the user can zoom in 
    public float zoomRate; // sets how fast the camera zooms in or out 

    private float currentFOV;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>(); // access the main camera 
        startingFOV = cam.fieldOfView; // sets the starting view of the camera to cam view
    }

    // Update is called once per frame
    void Update()
    {
        currentFOV = cam.fieldOfView;

        // reset the view to the starting view 
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentFOV = startingFOV; 
        }
        // zooms out with key O
        if (Input.GetKey(KeyCode.O))
        {
            currentFOV += zoomRate;
        }
        // zooms in with key I
        if (Input.GetKey(KeyCode.I))
        {
            currentFOV -= zoomRate;
        }
        // set the current field
        currentFOV = Mathf.Clamp(currentFOV, minFOV, maxFOV);
        cam.fieldOfView = currentFOV;
    }
}
