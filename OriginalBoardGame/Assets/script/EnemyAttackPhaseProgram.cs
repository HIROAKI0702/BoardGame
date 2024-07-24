using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackPhaseProgram : MonoBehaviour
{
    public GameManager gamemanager;
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;
    public ChoiceDice choicedice;
    public EnemyRandomDice ERD;
    public StatusChange SC;

    string playerDiceTag;
    string enemyDiceTag;

    public int e_count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void EnemyNormalSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyNormalBowFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyNormalShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyNormalArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyNormalStealFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyNormalCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPBowFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPStealFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }

    public void EnemyAPCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
        }
    }   
}