using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttackPhaseProgram : MonoBehaviour
{
    public GameManager gamemanager;
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyNormalSwordFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalSwordFunction");
            PSP.p_Hp -= ESP.e_SwordAttack;
            ESP.e_SwordAttackFlag = true;
            Debug.Log("プレイヤーに攻撃をして" + ESP.e_SwordAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp);
        }
    }

    public void EnemyNormalShieldFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalShieldFunction");
            if (PSP.p_BowAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_BowAttack;
                Debug.Log("プレイヤーの攻撃を無効化した、残りHP" + ESP.e_Hp);
            }
            PSP.p_BowAttackFlag = false;
        }
    }

    public void EnemyNormalBowFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalBowFunction");
            PSP.p_Hp -= ESP.e_BowAttack;
            ESP.e_BowAttackFlag = true;
            Debug.Log("プレイヤーに攻撃をして" + ESP.e_BowAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp);
        }
    }

    public void EnemyNormalArmerFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalArmerFunction");
            if (PSP.p_SwordAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_SwordAttack;
                Debug.Log("プレイヤーの攻撃を無効化した、残りHP" + ESP.e_Hp);
            }
            PSP.p_SwordAttackFlag = false;
        }
    }

    public void EnemyNormalStealFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            if (PSP.p_AitemPoint > 0)
            {
                Debug.Log("EnemyNormalStealFunction");
                PSP.p_AitemPoint--;
                ESP.e_AitemPoint++;
                Debug.Log("プレイヤーのアイテムポイントを1盗んだ、自分のアイテムポイントは" + ESP.e_AitemPoint);
            }
        }
    }

    public void EnemyNormalCounterFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalCounterFunction");
            if (PSP.p_SwordAttackFlag == true || PSP.p_BowAttackFlag == true)
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
                Debug.Log("プレイヤーの攻撃に反撃して" + ESP.e_CounterAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp);
            }
            PSP.p_CounterAttackFlag = false;
        }
    }

    public void EnemyAPSwordFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPSwordFunction");
            ESP.e_AitemPoint++;
            PSP.p_Hp -= ESP.e_SwordAttack;
            ESP.e_SwordAttackFlag = true;
            Debug.Log("プレイヤーに攻撃をして" + ESP.e_SwordAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp + "自分のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPShieldFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPShieldFunction");
            ESP.e_AitemPoint++;
            if (PSP.p_BowAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_BowAttack;
            }
            PSP.p_BowAttackFlag = false;
            Debug.Log("プレイヤーの攻撃を無効化した、残りHP" + ESP.e_Hp + "自分のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPBowFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPBowFunction");
            ESP.e_AitemPoint++;
            PSP.p_Hp -= ESP.e_BowAttack;
            ESP.e_BowAttackFlag = true;
            Debug.Log("プレイヤーに攻撃をして" + ESP.e_BowAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp + "自分のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPArmerFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPArmerFunction");
            ESP.e_AitemPoint++;
            if (PSP.p_SwordAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_SwordAttack;
            }
            PSP.p_SwordAttackFlag = false;
            Debug.Log("プレイヤーの攻撃を無効化した、残りHP" + ESP.e_Hp + "自分のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPStealFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPStealFunction");
            ESP.e_AitemPoint++;
            if (PSP.p_AitemPoint > 0)
            {
                ESP.e_AitemPoint++;
                PSP.p_AitemPoint--;
            }
            Debug.Log("プレイヤーのアイテムポイントを1盗んだ、自分のアイテムポイントは" + ESP.e_AitemPoint + "プレイヤーのアイテムポイント" + PSP.p_AitemPoint);
        }
    }

    public void EnemyAPCounterFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPCounterFunction");
            ESP.e_AitemPoint++;
            if (PSP.p_SwordAttackFlag == true || PSP.p_BowAttackFlag == true)
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
            }
            PSP.p_CounterAttackFlag = false;
            Debug.Log("プレイヤーの攻撃に反撃して" + ESP.e_CounterAttack + "ダメージ入った、プレイヤーの残りHP" + ":" + PSP.p_Hp + "自分のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

}
