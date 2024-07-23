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
                SC.EnemyStatusChangeFunction(ERD.selectObject[i], choicedice.selectObject[i]);
                count = 0;
            }
        }       
    }

    public void EnemyNormalSwordFunction()
    {
        count++;
    }

    public void EnemyNormalBowFunction()
    {
        count++;
    }

    public void EnemyNormalShieldFunction()
    {
        count++;
    }

    public void EnemyNormalArmerFunction()
    {
        count++;
    }

    public void EnemyNormalStealFunction()
    {
        count++;
    }

    public void EnemyNormalCounterFunction()
    {
       count++;
    }

    public void EnemyAPSwordFunction()
    {
        count++;
    }

    public void EnemyAPBowFunction()
    {
       count++;
    }

    public void EnemyAPShieldFunction()
    {
       count++;
    }

    public void EnemyAPArmerFunction()
    {
        count++;
    }

    public void EnemyAPStealFunction()
    {
       count++;
    }

    public void EnemyAPCounterFunction()
    {
        count++;
    }   
}