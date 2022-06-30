using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// added them to a system serializable because once it is running you wontr see the array this way fixes that
[System.Serializable]
public class BasicStats
{
    // set up user class
    public string UserClass;
    // set base attack and current attack power
    public float baseAttackPower;
    public float curAttackPower;
    //base attack current attack speed
    public float baseAttackSpeed;
    public float curAttackSpeed;
    // base dodge current dodge
    public float baseDodge;
    public float curDodge;
    // base and current hit percent
    public float baseHitPercent;
    public float curHitPercent;
}
