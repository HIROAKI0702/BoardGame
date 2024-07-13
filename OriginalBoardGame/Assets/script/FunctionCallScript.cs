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

//    public void PlayerDiceCallFunction(string tag, GameObject dice)
//    {
//        switch (tag)
//        {
//            case "NormalShield":
//                PAPP.PlayerNormalShieldFunction(dice);
//                break;
//            case "NormalArmer":
//                PAPP.PlayerNormalArmerFunction(dice);
//                break;
//            case "NormalCounter":
//                PAPP.PlayerNormalCounterFunction(dice);
//                break;
//            case "APShield":
//                PAPP.PlayerAPShieldFunction(dice);
//                break;
//            case "APArmer":
//                PAPP.PlayerAPArmerFunction(dice);
//                break;
//            case "APCounter":
//                PAPP.PlayerAPCounterFunction(dice);
//                break;
//            case "NormalSword":
//                PAPP.PlayerNormalSwordFunction(dice);
//                break;
//            case "NormalBow":
//                PAPP.PlayerNormalBowFunction(dice);
//                break;
//            case "NormalSteal":
//                PAPP.PlayerNormalStealFunction(dice);
//                break;
//            case "APSword":
//                PAPP.PlayerAPSwordFunction(dice);
//                break;
//            case "APBow":
//                PAPP.PlayerAPBowFunction(dice);
//                break;
//            case "APSteal":
//                PAPP.PlayerAPStealFunction(dice);
//                break;
//        }
//    }

//    public void EnemyDiceCallFunction(string tag, GameObject dice)
//    {
//        switch (tag)
//        {
//            case "NormalShield":
//                EAPP.EnemyNormalShieldFunction(dice);
//                break;
//            case "NormalArmer":
//                EAPP.EnemyNormalArmerFunction(dice);
//                break;
//            case "NormalCounter":
//                EAPP.EnemyNormalCounterFunction(dice);
//                break;
//            case "APShield":
//                EAPP.EnemyAPShieldFunction(dice);
//                break;
//            case "APArmer":
//                EAPP.EnemyAPArmerFunction(dice);
//                break;
//            case "APCounter":
//                EAPP.EnemyAPCounterFunction(dice);
//                break;
//            case "NormalSword":
//                EAPP.EnemyNormalSwordFunction(dice);
//                break;           
//            case "NormalBow":
//                EAPP.EnemyNormalBowFunction(dice);
//                break;           
//            case "NormalSteal":
//                EAPP.EnemyNormalStealFunction(dice);
//                break;          
//            case "APSword":
//                EAPP.EnemyAPSwordFunction(dice);
//                break;           
//            case "APBow":
//                EAPP.EnemyAPBowFunction(dice);
//                break;          
//            case "APSteal":
//                EAPP.EnemyAPStealFunction(dice);
//                break;           
//        }
//    }
}
