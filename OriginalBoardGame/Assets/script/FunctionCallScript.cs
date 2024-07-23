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
                PAPP.PlayerNormalShieldFunction();
                break;
            case "NormalArmer":
                PAPP.PlayerNormalArmerFunction();
                break;
            case "NormalCounter":
                PAPP.PlayerNormalCounterFunction();
                break;
            case "APShield":
                PAPP.PlayerAPShieldFunction();
                break;
            case "APArmer":
                PAPP.PlayerAPArmerFunction();
                break;
            case "APCounter":
                PAPP.PlayerAPCounterFunction();
                break;
            case "NormalSword":
                PAPP.PlayerNormalSwordFunction();
                break;
            case "NormalBow":
                PAPP.PlayerNormalBowFunction();
                break;
            case "NormalSteal":
                PAPP.PlayerNormalStealFunction();
                break;
            case "APSword":
                PAPP.PlayerAPSwordFunction();
                break;
            case "APBow":
                PAPP.PlayerAPBowFunction();
                break;
            case "APSteal":
                PAPP.PlayerAPStealFunction();
                break;
        }
    }

    public void EnemyDiceCallFunction(string tag, GameObject playerdice,GameObject enemydice)
    {
        switch (tag)
        {
            case "NormalShield":
                EAPP.EnemyNormalShieldFunction();
                break;
            case "NormalArmer":
                EAPP.EnemyNormalArmerFunction();
                break;
            case "NormalCounter":
                EAPP.EnemyNormalCounterFunction();
                break;
            case "APShield":
                EAPP.EnemyAPShieldFunction();
                break;
            case "APArmer":
                EAPP.EnemyAPArmerFunction();
                break;
            case "APCounter":
                EAPP.EnemyAPCounterFunction();
                break;
            case "NormalSword":
                EAPP.EnemyNormalSwordFunction();
                break;
            case "NormalBow":
                EAPP.EnemyNormalBowFunction();
                break;
            case "NormalSteal":
                EAPP.EnemyNormalStealFunction();
                break;
            case "APSword":
                EAPP.EnemyAPSwordFunction();
                break;
            case "APBow":
                EAPP.EnemyAPBowFunction();
                break;
            case "APSteal":
                EAPP.EnemyAPStealFunction();
                break;
        }
    }
}
