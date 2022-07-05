using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6HelloWorld : MonoBehaviour
{
    private Week6 playerOne;
    void Start()
    {
        playerOne = new Week6();
        playerOne.Name = "Barney";
        playerOne.Score = 100;
        playerOne.Lives = 3;
        
    }

     void OnDisable()
     {
         Debug.Log("Name:" + playerOne.Name + ", Score: " + playerOne.Score + ", Lives: " + playerOne.Lives);
     }
}
