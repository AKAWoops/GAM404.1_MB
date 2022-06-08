using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integers : MonoBehaviour
{
    //Variables go here
    //string dont do math
    [SerializeField]
    string playerHealth ="1";
    [SerializeField]
    string healAmount = "100";
    string finalHealth;
    // ints do math
    [SerializeField]
    int playerHealth2 = 1;
    [SerializeField]
    int healAmount2 = 100;
    int finalHealth2;

    // Start is called before the first frame update
    void Start()
    {
        // everything in these brackets is run when the game starts
        // strings out put one aftert the other as strings 1100 would be the output below
        finalHealth = playerHealth + healAmount;
        Debug.Log("Player is healed, now has:");
        Debug.Log(finalHealth);
        //INT doing math output below 101 would be output below
        finalHealth2 = playerHealth2 + healAmount2;
        Debug.Log("Player is healed, now has:");
        Debug.Log(finalHealth2);
        // or for output on the same line much cleaner
        Debug.Log("Player is Healed, now has: " + finalHealth2);
        // debug log takes in objects :-)
        // or can out put like this it will add the bracvkets first then spit out the int without brackets it would convert to 1100 as out put because it converts to string
        Debug.Log("Player is healed, now has: " + (finalHealth2 + healAmount2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
