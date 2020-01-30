using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{

    int minNumber = 1;
    int maxNumber = 1000;
    string playerName = "Artemka";
    int guess;
    

    //  bool isGameStarted = false;

    void Start()
    {
        Debug.Log("Привет :) " + playerName);
        StartGame();

        

    }
    void StartGame()
    {
        minNumber = 1;
        maxNumber = 1000;

        Debug.Log("Загадайте число");
        Debug.Log("Минимальноe число: " + minNumber);
        Debug.Log("Максимальноe число: " + maxNumber);
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = (minNumber + maxNumber) / 2;
        Debug.Log("А число твоё: " + guess + " ?");
    }

    void Update()
    {
        
       

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            minNumber = guess;
            UpdateGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            UpdateGuess();

        }
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Сча подумаем, твоё число:" + guess);
            StartGame();
        }


    }
}
