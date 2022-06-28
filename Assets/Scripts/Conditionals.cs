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
    [SerializeField]
    bool theEnd = false;
    bool printOnce = false;

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
        if (!printOnce && theEnd)
        {
           // if (theEnd)
            //{
                if (enemyHealth == 0)
                {
                    Debug.Log("Enemy is destroyed!");
                    Debug.Log("Player is the winner!");
                    //printOnce = true;
                }
                if (playerHealth == 0)
                {
                    Debug.Log("Player has Lost");
                    Debug.Log("try again ahahaa");
                    //printOnce = true;
                }
                printOnce = true;
        }
        if(theEnd == false)
        {
            if (playerAction == "Attack")
            {
                if(playerHealth != 0)
                {
                    enemyHealth = enemyHealth - playerAttack;
                }

                enemyHealth = enemyHealth - playerAttack;
                if (enemyHealth == 0)
                {
                    theEnd = true;
                }
                Debug.Log("Player attacks Enemy for" + playerAttack + " Damage!");
                Debug.Log("Enemy has " + enemyHealth);
                if(enemyHealth != 0)
                {
                    playerHealth = playerHealth - enemyAttack;
                }
                playerHealth = playerHealth - enemyAttack;
                if(playerHealth <= 0)
                {
                    theEnd = true;
                }
                Debug.Log("Enemy attacks back for " + enemyAttack + "damage!");
                Debug.Log("Player has " + playerHealth);

                // Debug.Log("then we can check update every seccond");
                // playerAction = "I Attacked";

                playerAction = "Attack Finished!";
            }
        }
        
    }
}
