using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    //Variables go here
    [SerializeField]
    string playerAction = "Default";
    [SerializeField]
    bool testbool = true;

    // Start is called before the first frame update
    void Start()
    {
        //everything in these brackets is run whn the game starts
        testbool = playerAction == "Attack";
        // another way to do the same above statement
        if(playerAction == "Attack")
        {
            Debug.Log("then this happens");
        }
        //another way to above statement is with != 
        if(playerAction != "Attack")
        {
            Debug.Log("then this happens");
        }
        if (testbool)
        {
            Debug.Log("Then this happens");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // everything in these brackets is callled everyframe
    }
}
