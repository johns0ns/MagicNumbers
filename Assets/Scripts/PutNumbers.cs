using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutNumbers : MonoBehaviour
{
    int num;
    int n;
    int click;
    int tap;

    void Start()
    {
        Debug.Log("Я хочу сыграть в игру... Нажми любую цифру: ");
        StartGame();
    }

    void StartGame()
    {
        click = 0;
        num = 0;
        n = 0;
        UpdateNum();
    }

    void UpdateNum()
    {
        num = num + n;
        click = click + tap;
        if (num != 0)
        {
            Debug.Log("Сумма : " + num);
        }
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            tap = 1;
            n = 1;
            UpdateNum();

        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            tap = 1;
            n = 2;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            tap = 1;
            n = 3;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            tap = 1;
            n = 4;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            tap = 1;
            n = 5;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            tap = 1;
            n = 6;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            tap = 1;
            n = 7;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            tap = 1;
            n = 8;
            UpdateNum();
        }

        else if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            tap = 1;
            n = 9;
            UpdateNum();

        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            num = 0;
            n = 0;
            Debug.Log("Вот нафига ты нажал пробел :facepalm: .... Лаааадно, начинаем сначала )");
            UpdateNum();

        }

        else if (num>=50)
        {
            Debug.Log("Happy end :D !!!  Сумма получилась: " + num + " Количество ходов:" + click);
            Start();
        }

    }
}
