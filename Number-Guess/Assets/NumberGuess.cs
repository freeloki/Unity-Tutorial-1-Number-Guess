using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuess : MonoBehaviour
{
    // Start is called before the first frame update

    int max = 100;
    int min = 1;
    int guess = 50;
    void Start()
    {
        // expression, variable, statement
    
        Debug.Log("Welcome to Number Guess Wizard");
        Debug.Log("Pick a number I will guess what it is...");
        Debug.Log("You can pick max:" + max);
        Debug.Log("You can pick min:" + min);
        Debug.Log("Is your number higher or lower than:" + guess);
        Debug.Log("Let's start!!!");
        max = max + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            //Debug.Log("Up Arrow Pressed!!!!!");
            min = guess;

            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than: " + guess);

        } else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down Arrow Pressed!!!!!");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than: " + guess);

        }else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am Awesome!!!! Your Number is: " + guess);
        }
        
    }
}
