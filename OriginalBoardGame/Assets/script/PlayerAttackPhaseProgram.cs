using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackPhaseProgram : MonoBehaviour
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

    public void PlayerNormalSwordFunction( GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for(int i = 0; i < 5; i++)
        {          
            if(choicedice.selectObject[i].tag == "NormalSword")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }           
        }
    }

    public void PlayerNormalBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "NormalBow")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }            
        }
    }

    public void PlayerNormalShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "NormalShield")
            {
                    SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
            
        }
    }

    public void PlayerNormalArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "NormalArmer")
            {
                  SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }           
        }
    }

    public void PlayerNormalStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "NormalSteal")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerNormalCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "NormalCounter")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APSword")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APBow")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APShield")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APArmer")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APSteal")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }

    public void PlayerAPCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        for (int i = 0; i < 5; i++)
        {
            if (choicedice.selectObject[i].tag == "APCounter")
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
            }
        }
    }
}
