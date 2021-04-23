/*Author: Darryl Williams 
 * About: way point script for the sphere 
 * This allow the sphere to follow way points 
 * either randomly or in order
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPoints : MonoBehaviour
{
    public GameObject[] waypoints; // create a array of waypoints
    int current = 0;  // current way point 
    public float speed; // speed of travel for the sphere
    float WPradius = 1; // set the waypoint radius

    void Update()
    {
        /* checks the distance of the way point 
         * and the sphere 
         */
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            //current = Random.Range(0, waypoints.Length); // randomize whwat point is next

            current++; // increments
            /*
             * checks if it is at the end 
             *  of way points and then set
             *  current back to zero to go back through the array
             */
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        // moves the sphere to the postion of the way points
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }
}

  