using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Note from Dev: Instructions are as follows:");
        Debug.Log("Press your up arrow if higher, and down arrow if lower, Enter(or return) as correct.");
        Debug.Log("...");
        Debug.Log("Welcome to my realm, I am the Wizard of Numbers!");
        Debug.Log("Ah, you wish to test my awesome powers? Choose a number, then!");
        Debug.Log("Ah, I must add that the highest number you can choose is: " + max);
        Debug.Log("And the smallest number that you can choose is: " + min);
        Debug.Log("Don't forget to keep it a secret! It would be too easy if you told me!");
        Debug.Log("Is your number higher or lower than 500?");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
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
            Debug.Log("Behold! I truly am the wisest of them all!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }



}
