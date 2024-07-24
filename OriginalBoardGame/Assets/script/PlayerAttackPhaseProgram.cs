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

    public int count;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerNormalSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerNormalBowFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerNormalShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerNormalArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerNormalStealFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerNormalCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerAPSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(p_dice, e_dice);
        }
    }

    public void PlayerAPBowFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerAPShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerAPArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerAPStealFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    public void PlayerAPCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        for (int i = 0; i < 1; i++)
        {
            SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }
}
