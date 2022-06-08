using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions1 : MonoBehaviour
{
    //Variables go here
    [SerializeField]
    int myint = 5;

    // Start is called before the first frame update
    void Start()
    {
        // myint = 55;
        //  Debug.Log(myint);
        myint = MultiplyByTwo(myint);
        Debug.Log(myint);  
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
