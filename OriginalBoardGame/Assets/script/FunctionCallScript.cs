using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionCallScript : MonoBehaviour
{
    public EnemyAttackPhaseProgram EAPP;
    public PlayerAttackPhaseProgram PAPP;
    public ChoiceDice choicedice;
    public EnemyRandomDice ERD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayerDiceCallFunction(string tag, GameObject playerdice, GameObject enemydice)
    {
        switch (tag)
        {
            case "NormalShield":
                PAPP.PlayerNormalShieldFunction(playerdice, enemydice);
                break;
            case "NormalArmer":
                PAPP.PlayerNormalArmerFunction(playerdice, enemydice);
                break;
            case "NormalCounter":
                PAPP.PlayerNormalCounterFunction(playerdice, enemydice);
                break;
            case "APShield":
                PAPP.PlayerAPShieldFunction(playerdice, enemydice);
                break;
            case "APArmer":
                PAPP.PlayerAPArmerFunction(playerdice, enemydice);
                break;
            case "APCounter":
                PAPP.PlayerAPCounterFunction(playerdice, enemydice);
                break;
            case "NormalSword":
                PAPP.PlayerNormalSwordFunction(playerdice, enemydice);
                break;
            case "NormalBow":
                PAPP.PlayerNormalBowFunction(playerdice, enemydice);
                break;
            case "NormalSteal":
                PAPP.PlayerNormalStealFunction(playerdice, enemydice);
                break;
            case "APSword":
                PAPP.PlayerAPSwordFunction(playerdice, enemydice);
                break;
            case "APBow":
                PAPP.PlayerAPBowFunction(playerdice, enemydice);
                break;
            case "APSteal":
                PAPP.PlayerAPStealFunction(playerdice, enemydice);
                break;
        }
    }

    public void EnemyDiceCallFunction(string tag, GameObject playerdice,GameObject enemydice)
    {
        switch (tag)
        {
            case "NormalShield":
                EAPP.EnemyNormalShieldFunction(playerdice, enemydice);
                break;
            case "NormalArmer":
                EAPP.EnemyNormalArmerFunction(playerdice, enemydice);
                break;
            case "NormalCounter":
                EAPP.EnemyNormalCounterFunction(playerdice, enemydice);
                break;
            case "APShield":
                EAPP.EnemyAPShieldFunction(playerdice, enemydice);
                break;
            case "APArmer":
                EAPP.EnemyAPArmerFunction(playerdice, enemydice);
                break;
            case "APCounter":
                EAPP.EnemyAPCounterFunction(playerdice, enemydice);
                break;
            case "NormalSword":
                EAPP.EnemyNormalSwordFunction(playerdice, enemydice);
                break;
            case "NormalBow":
                EAPP.EnemyNormalBowFunction(playerdice, enemydice);
                break;
            case "NormalSteal":
                EAPP.EnemyNormalStealFunction(playerdice, enemydice);
                break;
            case "APSword":
                EAPP.EnemyAPSwordFunction(playerdice, enemydice);
                break;
            case "APBow":
                EAPP.EnemyAPBowFunction(playerdice, enemydice);
                break;
            case "APSteal":
                EAPP.EnemyAPStealFunction(playerdice, enemydice);
                break;
        }
    }
}
