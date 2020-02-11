using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public Enemy enemy2;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello,my name is " + playerName); 
        Debug.Log(enemy2);
        enemy2.RunAway();
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
