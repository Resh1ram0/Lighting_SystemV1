using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Flashlight : MonoBehaviour
{
    private Light2D myLight;
    

    private void Start()
    {
        myLight = GetComponent<Light2D>();
        myLight.intensity = 0f;
        myLight.enabled = false;

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myLight.intensity = 0f;
            myLight.enabled = false;
            
        }
        
        else
        {
            myLight.intensity = 0.2f;
            myLight.enabled = true;

        }
        Thread.Sleep(250);


    }
}

// Looks for the GameObject "Light".
// Checks for any recent KeyCode.Space that has been triggered. (If Statement)
// (If Statement) Then change Inspector Intensity value to 0
// Checks for any recent KeyCode.Space that has been triggered. (Else Statement)
// (Else Statement) Then change  Inspector Intensity value to 0.2
// Create a randomized amount of number 1-3
// These numbers will carry an intensity light number from highest to lowest 0.2-0.075
// This will loop endlessly with a while statement with true.
// When it detect Input.GetKey(KeyCode.Space), then it will stop the loop.