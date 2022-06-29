using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserStats : MonoBehaviour
{
    //enter Username variable
    public string username;
    //current level if i get that far 
    public int level;
    // User Class meaning what character your going to pick
    public string UserClass;
    //Health Points
    public float CurHP;
    public float maxHP;
    //Mana
    public float curMana;
    public float maxMana;
    //Attack Power
    public float baseAttackPower;
    public float curAttackPower;
    //Attack Speed
    public float baseAttackSpeed;
    public float curAttackSpeed;
    //Dodge
    public float baseDodge;
    public float curDodge;
    // HIT current percentage chance
    public float baseHitPercent;
    public float curHitPercent;
    //health points regen timer and amount
    public float hpRegenTimer;
    public float hpRegenAmount;
    // Mana Regeneration timer and amount
    public float manaRegenTimer;
    public float manaRegenAmount;
    // experiennce points
    public float curXp;
    public float maxXp;

    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
