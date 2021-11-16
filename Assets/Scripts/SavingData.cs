using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script used to learn how to save data.
/// </summary>
public class SavingData : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Stored score is "+ GetScore());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Increase score by 1
            score++;
            Debug.Log("Current Score is "+ score);
            // If the score is greater than the score already had,
            if (score > GetScore())
            {
                // Set a new score
                PlayerPrefs.SetInt("Score", 0);
                Debug.Log(PlayerPrefs.GetInt("Score"));
            }
        }
    }

    int GetScore()
    {
        // This method returns the integer with the corresponding passed key.
        // If there's no value in the passed key, it will return 0.
        int myScore = PlayerPrefs.GetInt("Score", 0);
        return myScore;
    }
}
