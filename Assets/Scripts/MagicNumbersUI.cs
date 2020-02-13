using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MagicNumbersUI : MonoBehaviour
{
    public int minNumber = 1;
    public int maxNumber = 1000;
    int guess;
    int click;
    public Text textguess;
    public TextMeshProUGUI textCount;
    


    void Start()
    {

        //guess = Random.Range(minNumber, maxNumber + 1);
        guess = (minNumber + maxNumber) / 2;
        textguess.text = "Ваше число " + guess + " ?";
        less();

        textCount.text = "Количество ходов " + 2;


    }


    void less()
    
    {
        minNumber = guess;


        
    }

    void Update()
    { 
    }
   
}
