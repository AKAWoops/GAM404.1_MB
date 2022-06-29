using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// added them to a system serializable because once it is running you wontr see the array this way fixes that
[System.Serializable]
public class BasicStats
{
    public string UserClass;
    public float baseAttackPower;
    public float curAttackPower;
    public float baseAttackSpeed;
    public float curAttackSpeed;
    public float baseDodge;
    public float curDodge;
    public float baseHitPercent;
    public float curHitPercent;
}
