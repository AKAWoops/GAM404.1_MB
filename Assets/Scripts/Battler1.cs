using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battler1 : MonoBehaviour
{
    //variable go here
    Battler player = new Battler(200, 200);
    Battler enemy = new Battler(25, 25, 5);
    [SerializeField]bool attack = false;



    // Start is called before the first frame update
    void Start()
    {
        //nopt needed any more :-) constructors lol
        //enemy.maxHP = 25;
        //enemy.hp = enemy.maxHP;

    }

    // Update is called once per frame
    void Update()
    {
        if(attack)
        {
            enemy.hp = enemy.hp - player.attack;
            Debug.Log("Enemy was attacked, has " + enemy.hp + " left ");
            attack = false;
        }
    }
}

public class Battler
{
    //variable
    public int maxHP = 100;
    public int hp = 100;
    public int attack = 25;

    //Constructor for battle hp 
    public Battler(int nMaxHP = 100, int nHP = 100, int nAttack = 25)
    {
        maxHP = nMaxHP;
        hp = nHP;
        attack = nAttack;
    }

}