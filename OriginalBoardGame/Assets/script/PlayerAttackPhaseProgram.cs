using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackPhaseProgram : MonoBehaviour
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

    public void PlayerNormalSwordFunction(GameObject dice)
    {
        if(gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalSwordFunction");
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_SwordAttackFlag = true;
            Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }
    }

    public void PlayerNormalShieldFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalShieldFunction");
            if(ESP.e_BowAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_BowAttack;
                Debug.Log("敵の攻撃を受けて5ダメージ受けた、残りHP" + PSP.p_Hp);
            }
            ESP.e_BowAttackFlag = false;
        }
    }

    public void PlayerNormalBowFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalBowFunction");
            ESP.e_Hp -= PSP.p_BowAttack;
            PSP.p_BowAttackFlag = true;
            Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }
    }

    public void PlayerNormalArmerFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalArmerFunction");
            if (ESP.e_SwordAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_SwordAttack;
                Debug.Log("敵の攻撃を受けて5ダメージ受けた、残りHP" + PSP.p_Hp);
            }
            ESP.e_SwordAttackFlag = false;
        }
    }

    public void PlayerNormalStealFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            if (ESP.e_AitemPoint >= 1)
            {
                Debug.Log("PlayerNormalStealFunction");
                ESP.e_AitemPoint--;
                PSP.p_AitemPoint++;
                Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
            }
        }
    }

    public void PlayerNormalCounterFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalCounterFunction");
            if(ESP.e_SwordAttackFlag == true || ESP.e_BowAttackFlag)
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
                Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
            }
            ESP.e_CounterAttackFlag = false;
        }
    }

    public void PlayerAPSwordFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPSwordFunction");
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_SwordAttackFlag = true;
            PSP.p_AitemPoint++;
            Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp + "自分のアイテムポイント" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPShieldFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPShieldFunction");
            if (ESP.e_BowAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_BowAttack;
            }
            PSP.p_AitemPoint++;
            ESP.e_BowAttackFlag = false;
            Debug.Log("敵の攻撃を受けて5ダメージ受けた、残りHP" + PSP.p_Hp + "自分のアイテムポイント" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPBowFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPBowFunction");
            ESP.e_Hp -= PSP.p_BowAttack;
            PSP.p_BowAttackFlag = true;
            PSP.p_AitemPoint++;
            Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp + "自分のアイテムポイント" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPArmerFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPArmerFunction");
            if (ESP.e_SwordAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_SwordAttack;
            }
            PSP.p_AitemPoint++;
            ESP.e_SwordAttackFlag = false;
            Debug.Log("敵の攻撃を受けて5ダメージ受けた、残りHP" + PSP.p_Hp + "自分のアイテムポイント" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPStealFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            if (ESP.e_AitemPoint >= 1)
            {
                PSP.p_AitemPoint++;
                ESP.e_AitemPoint--;
            }
            Debug.Log("PlayerAPStealFunction");
            PSP.p_AitemPoint++;
            Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint + "敵のアイテムポイント" + ESP.e_AitemPoint);
        }
    }

    public void PlayerAPCounterFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPCounterFunction");
            if (ESP.e_SwordAttackFlag == true || ESP.e_BowAttackFlag)
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
            }
            PSP.p_AitemPoint++;
            ESP.e_CounterAttackFlag = false;
            Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp + "自分のアイテムポイント" + PSP.p_AitemPoint);
        }
    }
}
