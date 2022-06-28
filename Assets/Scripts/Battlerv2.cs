using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlerv2 : MonoBehaviour
{
    //variable go here
    [SerializeField] bool alchemizes = false;
    [SerializeField] bool earth = true;
    [SerializeField] bool fire = true;
    [SerializeField] bool wind = false;


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
        if (alchemizes)
        {
            if(earth && fire && wind)
            {
                print("You cast explosion!");
            }
            else if (earth && fire)
            {
                print("You cast lava!");
            }
            else if (fire && wind)
            {
                print("you cast Inferno!");
            }
            else if (wind && earth)
            {
                print("You cast Nature!");
            }
            else if (earth)
            {
                print("You cast Rumble!");
            }
            else if (fire)
            {
                print("You cast Fireball");
            }
            else if (wind)
            {
                print("You cast Windblade!");
            }
            else
            {
                print("SPLASH!!!");
            }
            earth = false;
            fire = false;
            wind = false;
            alchemizes = false;
        }
    }
}
/*
public class Battler1
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
*/