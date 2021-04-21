using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTool : MonoBehaviour
{
    public Transform target;
    public float speed = 2.5f;
    public Collider hitColliders;



    void Start()
    {
        //Fetch the GameObject's Collider (make sure they have a Collider component)
        hitColliders = GetComponent<Collider>();
        //Here the GameObject's Collider is not a trigger
        hitColliders.isTrigger = false;
    }

    // void OnMouseDown()
    // {
    //     //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
        // hitColliders.isTrigger = true;
        // Debug.Log("hitCollider activated");
    // }

    void Update ()
    {    
        hitColliders.isTrigger = true;
    }

    private void OnTriggerStay(Collider hitColliders) {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerEnter(Collider hitColliders)
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    private void OnTriggerExit(Collider hitColliders)
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
