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
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalSword")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyNormalBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalBow")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyNormalShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalShield")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyNormalArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalArmer")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyNormalStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalSteal")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyNormalCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "NormalCounter")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "APSword")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "APBow")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "APShield")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "APArmer")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (ERD.selectObject[i].tag == "APSteal")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }

    public void EnemyAPCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {            
            if (ERD.selectObject[i].tag == "APCounter")
            {
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
            }
        }
    }   
}