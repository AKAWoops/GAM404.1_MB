using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strings : MonoBehaviour
{

    // variables go here
    string stringA = "This Is A Test";
    string stringB;
    [SerializeField]
    string playerName = "Mark B";


    // Start is called before the first frame update
    void Start()
    {
        // things between the bracketrs run when games starts
        stringB = stringA;
        // if you want this line to pri nt twice add it above the above stringB statement :-)
        stringA = "test string a seccond test overides stringA";
        Debug.Log(stringA);
        Debug.Log(stringB);
        Debug.Log("Player Name is: ");
        Debug.Log(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
