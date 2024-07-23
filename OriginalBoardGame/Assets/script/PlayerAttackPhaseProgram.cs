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
        for(int i = 0; i < 1; i++)
        {
            if (count == 5)
            {
                SC.PlayerStatusChangeFunction(choicedice.selectObject[i], ERD.selectObject[i]);
                count = 0;
            }
        }        
    }

    public void PlayerNormalSwordFunction()
    {      
         count++;
    }

    public void PlayerNormalBowFunction()
    {       
        count++;       
    }

    public void PlayerNormalShieldFunction()
    {
        count++;
    }

    public void PlayerNormalArmerFunction()
    {
        count++;
    }

    public void PlayerNormalStealFunction()
    {      
        count++;
    }

    public void PlayerNormalCounterFunction()
    {
        count++;
    }

    public void PlayerAPSwordFunction()
    {
        count++;                
    }

    public void PlayerAPBowFunction()
    {
        count++;
    }

    public void PlayerAPShieldFunction()
    {
        count++;
    }

    public void PlayerAPArmerFunction()
    {
        count++;
    }

    public void PlayerAPStealFunction()
    {    
        count++;
    }

    public void PlayerAPCounterFunction()
    {
        count++;
    }
}
