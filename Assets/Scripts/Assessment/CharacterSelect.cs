using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour
{
    //array to store stats for characters class 
    public BasicStats[] AllClassStats;
    // this is for the window to pop up using bool for gui button push
    public bool ClassSelectWindow;

    public GameObject User;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnGUI()
    { //if it is set to true the window will display the 2 buttons below
        if (ClassSelectWindow)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 40), "Class1"))
            {   //window disables after slection of character
                AssignBaseStats(0);// array zero
                ClassSelectWindow = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 40), "CLASS 2"))
            {
                AssignBaseStats(1);// array one
                ClassSelectWindow = false;
            }
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    void AssignBaseStats (int classChosen)
    { // grabbing user stats form up above and then letting you select from 1 or 2 below
        var Comp = User.GetComponent<UserStats>();
        // call userclass string in user stats then we set it to all class stats then the class chosen from array 0 or 1
        Comp.UserClass = AllClassStats[classChosen].UserClass;
        // to change variable for classes
        Comp.baseAttackPower = AllClassStats[classChosen].baseAttackPower;
        Comp.baseAttackSpeed = AllClassStats[classChosen].baseAttackSpeed;
    }
}

