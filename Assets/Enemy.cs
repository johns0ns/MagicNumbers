using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Player Player123;


    // Start is called before the first frame update
    void Start()
    {
        Player123.playerName = "BAAAD PLAYER";
        Debug.Log("Hello " + Player123.playerName + " I am your enemy");

    }

    public void RunAway()
    {
        Debug.Log("I'm Scared");
    }
    void Win()
    {
     Debug.Log("I'm Winner");

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
