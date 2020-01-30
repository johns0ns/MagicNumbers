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
        Debug.Log("Загадайте число");
        Debug.Log("Минимальноe число: " + minNumber);
        Debug.Log("Максимальноe число: " + maxNumber);

        guess = (minNumber + maxNumber) / 2;
        Debug.Log("А число твоё: " + guess + " ?");

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Мой мозг не хуже чем у Стивена Хокинга хи-хи-хи :)! Твоё число было : "+ guess);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Сча подумаем, твоё число:" + guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Ммммм, твоё число в таком случае:" +);
        }


    }
}
