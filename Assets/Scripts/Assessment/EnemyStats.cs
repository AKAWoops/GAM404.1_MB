using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float curHp;
    public float maxHp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // as we discussed in the other script i made this will stop it going past zero into negative numbers
        if(curHp <= 0)
        {
            curHp = 0;
        }    
    }

    public void RecievedDamage (float dmg)
    {// current health by damage delt -=
        curHp -= dmg;

        print("damage delt = " + dmg);
        print("Enemy HP Left = " + curHp);
    }
}
