using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Method 2
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i);
            }
            /// Method 2
            for (int j = 1; j <= 100; j++)
            {
                string str = "";
                if (j % 3 == 0)
                {
                    str += "Fizz";
                }
                if (j % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = j.ToString();
                }
                Debug.Log(str);

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
