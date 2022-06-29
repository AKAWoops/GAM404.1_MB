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
    // player died
    public bool isDead;
    // 
    public GameObject selectedUnit;
    //for access to enemy stats script
    public EnemyStats enemyStatsScript;

    // is player behind enemy cant attack
    public bool behindenemy;
    //infront of enemy can attack
    public bool canAttack;
    // attack timer
    public float autoAttackCooldown;
    public float autoAttackCurTime;
    public bool canAutoAttack;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectTarget(0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            SelectTarget(1);
        }
        /* //test variable for bottom test script
         if (Input.GetKeyDown("1"))
         {// just to make sure there are no nulls thrown might work here
             if(selectedUnit != null)  
                 BasicAttack();*/
        //if not enemy is selected we dont want to do any thing
        if (selectedUnit != null)
        {
            //if we have enemy selected we first grab positions of selected unit and then 
            Vector3 toTarget = (selectedUnit.transform.position - transform.position).normalized;
            // check if player is behind enemy now i can calculate dodge, parry extra damage etc etc
            // makes sure by check if players are facing are paralell or facing away
            if (Vector3.Dot(toTarget, selectedUnit.transform.forward) < 0)
            {
                behindenemy = false;
            }
            else
            {
                behindenemy = true;
            }
            //this will calculate if player is facing the enemy and is within distance for aggro
            float distance = Vector3.Distance(this.transform.position, selectedUnit.transform.position);
            Vector3 targetDir = selectedUnit.transform.position - transform.position;
            Vector3 forward = transform.forward;
            float angle = Vector3.Angle(targetDir, forward);
            //if any thing greater tha 60 degress is out of los and will not attack
            if (angle > 60.0)
            {
                canAttack = false;
            }
            else
            {
                if (distance < 60.0)
                {
                    canAttack = true;
                }
                else
                {
                    canAttack = false;
                }
            }
        }

        // Automatic attack with cool down timer
        if (selectedUnit != null && canAttack && canAutoAttack = true)
        {
            if(autoAttackCurTime < autoAttackCooldown)
            {//while the number above is lower then the belowe number it will count up with deltaTime
                autoAttackCurTime += Time.deltaTime;
            }
            else
            {
                BasicAttack();
                autoAttackCurTime = 0;// this will reset it at zero
            }
        }
        //Attacks bind to onkeydown press 1
        if (Input.GetKeyDown("1"))
        {
            //make sure player is facing enemy and is in range
            if (selectedUnit != null && canAttack)
                 BasicAttack();
            canAutoAttack = true;
        }
    }
        void SelectTarget(int selectedNum)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // this checks for hits ot enemy tag attached to enemy :-)
            if (Physics.Raycast(ray, out hit, 10000))
            {
                if (hit.transform.tag == "enemy")
                {

                    selectedUnit = hit.transform.gameObject;
                    // grabs stats from selected unit displays enemy stats
                    enemyStatsScript = selectedUnit.transform.gameObject.transform.GetComponent<EnemyStats>();

                // make sure enemy is selcted first above
                    if (selectedNum == 0)
                    {
                    canAutoAttack = false;
                    }
                    else if (selectedNum == 1)
                    {
                    canAutoAttack = true;
                    }
                }
            }
        }
        // test variable
        void BasicAttack()
        {
            enemyStatsScript.RecievedDamage(10);
        }
    }

