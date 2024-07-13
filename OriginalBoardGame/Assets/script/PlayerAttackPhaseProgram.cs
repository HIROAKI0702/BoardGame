using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackPhaseProgram : MonoBehaviour
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

    public void ConpaireDice()
    {
        //敵のサイコロの数と自分のサイコロの数が同じであるかを確認
        int diceCount = Mathf.Min(choicedice.selectObject.Count, ERD.selectObject.Count);

        for (int i = 0; i < diceCount; i++)
        {
            StatusChange(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    private void StatusChange(GameObject playerDice,GameObject enemyDice)
    {
        string playerDiceTag = playerDice.tag;
        string enemyDiceTag = enemyDice.tag;

        //自分のダイスが剣ダイスの時かつ敵のダイスが鎧ダイスでない場合ダメージを入れる
        if(playerDiceTag == "NormalSword" && (enemyDiceTag != "NoromalArmer" || enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        //自分のダイスが弓ダイスの時かつ敵のダイスが盾ダイスでない場合ダメージを入れる
        if (playerDiceTag == "NormalBow" &&(enemyDiceTag != "NormalShiel" || enemyDiceTag != "APShiel"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        //自分のダイスが盗みダイスの時かつ敵のアイテムポイントが１以上の場合
        if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
        }

        //自分のダイスがカウンターダイスかつ敵のダイスが弓または剣のダイスの場合カウンターダメージを入れる
        if (playerDiceTag == "NoromalCounter" && 
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") || 
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        //自分のダイスが鎧ダイスかつ敵のダイスが剣の場合何もせず無効化する
        if (playerDiceTag == "NormalArmor" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
        {
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        //自分のダイスが盾ダイスかつ敵のダイスが弓の場合何もせず無効化する
        if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APSword" && (enemyDiceTag != "NoromalArmer" || enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_AitemPoint++;
            Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APBow" && (enemyDiceTag != "NormalShiel" || enemyDiceTag != "APShiel"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            PSP.p_AitemPoint++;
            Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            PSP.p_AitemPoint++;
            Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
        }

        if (playerDiceTag == "APCounter" &&
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") ||
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            PSP.p_AitemPoint++;
            Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APArmor" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
        {
            PSP.p_AitemPoint++;
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            PSP.p_AitemPoint++;
            Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
        }

        //HPが０以下にならないようにする
        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }
}
