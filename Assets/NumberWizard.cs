using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;
        Debug.Log("Welcome to my realm, I am the Wizard of Numbers!");
        Debug.Log("Ah, you wish to test my awesome powers? Choose a number, then!");
        Debug.Log("Ah, I must add that the highest number you can choose is: " + max);
        Debug.Log("And the smallest number that you can choose is: " + min);
        Debug.Log("Don't forget to keep it a secret! It would be too easy if you told me!");
        Debug.Log("Is your number higher or lower than 500?");
        Debug.Log("Press your up arrow if higher, and down arrow if lower.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Return key was pressed.");
        }




    }

}
