using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : MonoBehaviour
{
    public GameManager gamemanager;
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;
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

    public void PlayerStatusChangeFunction(GameObject playerDice, GameObject enemyDice)
    {
        string playerDiceTag = playerDice.tag;
        string enemyDiceTag = enemyDice.tag;

        //自分のダイスが剣ダイスの時かつ敵のダイスが鎧ダイスでない場合ダメージを入れる
        if (playerDiceTag == "NormalSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        //自分のダイスが弓ダイスの時かつ敵のダイスが盾ダイスでない場合ダメージを入れる
        if (playerDiceTag == "NormalBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }
        else
        {
            PSP.p_BowAttack = 0;
            Debug.Log("a");
        }

        //自分のダイスが盗みダイスの時かつ敵のアイテムポイントが１以上の場合
        if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
        }

        //自分のダイスがカウンターダイスかつ敵のダイスが弓または剣のダイスの場合カウンターダメージを入れる
        if (playerDiceTag == "NormalCounter" &&
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") ||
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        //自分のダイスが鎧ダイスかつ敵のダイスが剣の場合何もせず無効化する
        if (playerDiceTag == "NormalArmer" && (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword"))
        {
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        //自分のダイスが盾ダイスかつ敵のダイスが弓の場合何もせず無効化する
        if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APSword")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
            {
                ESP.e_Hp -= PSP.p_SwordAttack;
                Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
            }          
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        if (playerDiceTag == "APBow")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
            {
                ESP.e_Hp -= PSP.p_BowAttack;
                Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
            }            
        }
        else
        {
            PSP.p_BowAttack = 0;
        }

        if (playerDiceTag == "APSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint += 2;
            Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
        }

        if (playerDiceTag == "APCounter")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APCounter" && 
                (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") || 
                (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
                Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
            }          
        }

        if (playerDiceTag == "APArmer")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APArmer" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
            {
                Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
            }
            
        }

        if (playerDiceTag == "APShield")
        {
            PSP.p_AitemPoint++;
            if(playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
            {
                Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
            }
        }

        //HPが０以下にならないようにする
        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }

    public void EnemyStatusChangeFunction(GameObject enemyDice, GameObject playerDice)
    {
        string playerDiceTag = playerDice.tag;
        string enemyDiceTag = enemyDice.tag;

        if (enemyDiceTag == "NormalSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
        {
            PSP.p_Hp -= ESP.e_SwordAttack;
            Debug.Log("敵に攻撃をして" + ESP.e_SwordAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        if (enemyDiceTag == "NormalBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
        {
            PSP.p_Hp -= ESP.e_BowAttack;
            Debug.Log("敵に攻撃をして" + ESP.e_BowAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
        }
        else
        {
            PSP.p_BowAttack = 0;
        }

        if (enemyDiceTag == "NormalSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint++;
            Debug.Log("敵のアイテムポイントを1盗んだ、敵のアイテムポイントは" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "NormalCounter" &&
            (playerDiceTag == "NormalSword" || playerDiceTag == "APSword" ||
            playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            PSP.p_Hp -= ESP.e_CounterAttack;
            Debug.Log("敵の攻撃に反撃して" + ESP.e_CounterAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "NormalArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
        {
            Debug.Log("敵の攻撃を無効化した、敵の残りHP" + ESP.e_Hp);
        }

        if (enemyDiceTag == "NormalShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            Debug.Log("敵の攻撃を無効化した、敵の残りHP" + ESP.e_Hp);
        }

        if (enemyDiceTag == "APSword")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
            {
                PSP.p_Hp -= ESP.e_SwordAttack;
                Debug.Log("敵に攻撃をして" + ESP.e_SwordAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
            }           
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        if (enemyDiceTag == "APBow")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
            {
                PSP.p_Hp -= ESP.e_BowAttack;
                Debug.Log("敵に攻撃をして" + ESP.e_BowAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
            }
        }
        else
        {
            PSP.p_BowAttack = 0;
        }

        if (enemyDiceTag == "APSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint += 2;
            Debug.Log("敵のアイテムポイントを2盗んだ、敵のアイテムポイントは" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "APCounter")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APCounter" && 
                (playerDiceTag == "NormalSword" || playerDiceTag == "APSword") || 
                (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
                Debug.Log("敵の攻撃に反撃して" + ESP.e_CounterAttack + "ダメージ入った、プレイヤーの残りHP:" + PSP.p_Hp);
            }            
        }

        if (enemyDiceTag == "APArmer")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
            {
                Debug.Log("敵の攻撃を無効化した、敵の残りHP" + PSP.p_Hp);
            }
        }

        if (enemyDiceTag == "APShield")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
            {
                Debug.Log("敵の攻撃を無効化した、敵の残りHP" + PSP.p_Hp);
            }
        }

        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }
}
