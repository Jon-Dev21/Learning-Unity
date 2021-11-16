using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("Trigger");
        // This method destroys the game object passed.
        // In this case, gameObject is the object that contains this trigger script.
        Destroy(gameObject);
    }
}
