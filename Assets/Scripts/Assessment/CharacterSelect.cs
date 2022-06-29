using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour
{
    //array to store stats for characters class 
    public BasicStats[] AllClassStats;
    public bool ClassSelectWindow;
    public GameObject User;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnGUI()
    {
        if (ClassSelectWindow)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 150, 200, 40), "Class1"))
            {
                AssignBaseStats(0);
                ClassSelectWindow = false;
            }
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 40), "CLASS 2"))
            {
                AssignBaseStats(1);
                ClassSelectWindow = false;
            }
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    void AssignBaseStats (int classChosen)
    {
        var Comp = User.GetComponent<UserStats>();

        Comp.UserClass = AllClassStats[classChosen].UserClass;
        Comp.baseAttackPower = AllClassStats[classChosen].baseAttackPower;
    }
}

