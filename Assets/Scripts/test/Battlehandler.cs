using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battlehandler : MonoBehaviour
{
    [SerializeField] private Transform pfCharacterBattle;
    public Texture3D playerSpriteSheet;
    public Texture3D EnemySpriteSheet;
    private void Start()
    {
        SpawnCharacter(true);
        SpawnCharacter(false);
    }

    private void SpawnCharacter(bool isPlayerTeam)
    {
        Vector3 position;
        if (isPlayerTeam)
        {
            position = new Vector3(-50, 0);
        }
        else
        {
            position = new Vector3(+50, 0);
        }
        Instantiate(pfCharacterBattle, position, Quaternion.identity);
    }
}
