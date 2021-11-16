using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script used to learn how to instanciate objects via code.
/// </summary>
public class InstanciateCubes : MonoBehaviour
{
    // Variable for storing a prefab
    public Transform prefab;

    int counter = 0;

    // Start is called before the first frame update
    //void Start()
    //{
    //    for (int i = 0; i < 10; i++)
    //    {
    //        // In this overload of the Instantiate method,
    //        // you pass the prefab object, a position and the rotation.
    //        Instantiate(prefab, new Vector3(i* 3.0F, i + 5 , -39), Quaternion.identity);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        // When spacebar is pressed, create a new object.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(40, counter + 5, 0), Quaternion.identity);
            counter++;
        }
    }

    private void Start()
    {
        // Name of method, after how many seconds do we want to start, how often should it invoke
        InvokeRepeating("CreateNewCube", 2f, 0.1f);

        // To invoke only once, use Invoke
        Invoke("CreateNewCube", 2f);
    }

    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(40, counter + 5, 0), Quaternion.identity);
        counter++;

        if (counter >= 5000)
        {
            CancelInvoke();
        }
    }
}
