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
    [SerializeField]
    int enemyHealth = 10;
    [SerializeField]
    int playerHealth = 10;
    [SerializeField]
    int playerAttack = 2;
    [SerializeField]
    int enemyAttack = 2;

    // Start is called before the first frame update
    void Start()
    {
        //everything in these brackets is run whn the game starts
        // testbool = playerAction == "Attack";
        // another way to do the same above statement
        // if(playerAction == "Attack")
        //  {
        //      Debug.Log("then we can check start");
        //  }
        //another way to above statement is with != 
        //  if(playerAction != "Attack")
        //   {
        //     Debug.Log("then we can check start");
        //  }
        //  if (testbool)
        // {
        //      Debug.Log("Then this happens at start");
        //  }

        Debug.Log("ZAP once the smoke has cleared you notice An enemy blocks your way what are you going to do ? write Attack to Attack");

    }

    // Update is called once per frame
    void Update()
    {
        // everything in these brackets is callled everyframe of the game
        if (playerAction == "Attack")
        {
            enemyHealth = enemyHealth - playerAttack;
            Debug.Log("Player attacks Enemy for" + playerAttack + " Damage!");
            Debug.Log("Enemy has " + enemyHealth);
            playerHealth = playerHealth - enemyAttack;
            Debug.Log("Enemy attacks back for " + enemyAttack + "damage!");
            Debug.Log("Player has " + playerHealth);

            // Debug.Log("then we can check update every seccond");
            // playerAction = "I Attacked";

            playerAction = "Attack Finished!";
        }
    }
}
