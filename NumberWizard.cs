using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{

    int max;
    int min;
    int guess;

	// Use this for initialization
	void Start () 
    {
        StartGame();
	}

    // Use this to Start Game 
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard");
        Debug.Log("Please pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is lower than my guess: " + guess);
        Debug.Log("Push Up Arrow if = higher, Push down Arrow if = lower, push enter if = correct");
        max = max + 1;  
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Sweet I was right.");
            StartGame();
        }

	}

    // Next Guess 
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than: " + guess); 
    }
}
