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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            {
             SelectTarget();
        }
        //test variable for bottom test script
        if (Input.GetButtonDown("1"))
        {
            if(selectedUnit != null)  
                BasicAttack();
        }
    }
    void SelectTarget()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // this checks for hits ot enemy tag attached to enemy :-)
        if (Physics.Raycast(ray, out hit, 10000))
            {
            if (hit.transform.tag == "enemy") {

                selectedUnit = hit.transform.gameObject;
                // grabs stats from selected unit displays enemy stats
                enemyStatsScript = selectedUnit.transform.gameObject.transform.GetComponent<EnemyStats>();
            }
        }
    }
    // test variable
    void BasicAttack()
    {
        enemyStatsScript.RecievedDamage(10);
    }
}
