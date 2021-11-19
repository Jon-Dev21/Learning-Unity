using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
    //    // Structure used to get information back from a raycast.
    //    RaycastHit hit;

    //    // Physics.Raycast method has many overloads.
    //    // The one used here is (raycastPositionOrigin, directionVector,MaxDistance,LayerMask)

    //    if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100f))
    //    {
    //        print("Something is below the object at " + hit.transform.position);
    //    } else
    //    {
    //        print("Nothing underneath this object "+ gameObject.name);
    //    }
    //}

    // Now will use Ray instead of Raycast.
    void Update()
    {
        // To know what i've hit
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // Mouse position is a vector3 with the current position of ourmouse.
        // The camera is the device from which a player views the world.

        // Checking if there is something within a distance of 100 from where the mouse is at.
        if (Physics.Raycast(ray, out hit, 100f))
        {
            print("Ray hit object" + hit.collider.gameObject.name);
        }
    }
}
