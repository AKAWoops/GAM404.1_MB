using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    //Variables go here
    [SerializeField]
    string name;
    [SerializeField]
    string gender;

    int playerHP = 10;
    int enemyHP = 100;

    // Start is called before the first frame update
    void Start()
    {
        //Everything in these brackets is run when the game starts
        Debug.Log("My name is " + name + "and I am " + gender);
    }

    // Update is called once per frame
    void Update()
    {
        //Everything in these brackets is run every frame of the game
    }
}

public void Battler
{
    // Variables
    int maxHP = 100;
    int hp = 100;
    int attackPower = 12;
}