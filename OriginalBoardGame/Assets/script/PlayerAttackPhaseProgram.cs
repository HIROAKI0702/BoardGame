using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackPhaseProgram : MonoBehaviour
{
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;
    public ChoiceDice choicedice;
    public EnemyRandomDice ERD;
    public StatusChange SC;
    public EnemyAttackPhaseProgram EAPP;
    public FunctionCallScript FCS;

    string playerDiceTag;
    string enemyDiceTag;

    public int p_count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FCS.statusFlag == true)
        {
            for (int i = 0; i < 1; i++)
            {
                playerDiceTag = choicedice.selectObject[i].tag;
                enemyDiceTag = ERD.selectObject[i].tag;

                //自分のダイスが剣ダイスの時かつ敵のダイスが鎧ダイスでない場合ダメージを入れる
                if (playerDiceTag == "NormalSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
                {
                    ESP.e_Hp -= PSP.p_SwordAttack;
                    Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }
                else if (playerDiceTag == "NormalSword" && (enemyDiceTag == "NormalArmer" && enemyDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("敵に攻撃をしたが無効化され" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }

                //自分のダイスが弓ダイスの時かつ敵のダイスが盾ダイスでない場合ダメージを入れる
                if (playerDiceTag == "NormalBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
                {
                    ESP.e_Hp -= PSP.p_BowAttack;
                    Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }
                else if (playerDiceTag == "NormalBow" && (enemyDiceTag == "NormalShield" && enemyDiceTag == "APShield"))
                {
                    PSP.p_BowAttack = 0;
                    Debug.Log("敵に攻撃をしたが無効化され" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }

                //自分のダイスが盾ダイスかつ敵のダイスが弓の場合何もせず無効化する
                if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
                {
                    Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
                }

                //自分のダイスが鎧ダイスかつ敵のダイスが剣の場合何もせず無効化する
                if (playerDiceTag == "NormalArmer" && (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword"))
                {
                    Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
                }

                //自分のダイスが盗みダイスの時かつ敵のアイテムポイントが１以上の場合自分のアイテムポイントを＋２敵のアイテムポイントをー１
                if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
                {
                    ESP.e_AitemPoint--;
                    PSP.p_AitemPoint++;
                    Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
                }

                //自分のダイスがカウンターダイスかつ敵のダイスが弓または剣のダイスの場合カウンターダメージを入れる
                if (playerDiceTag == "NormalCounter" &&
                    (enemyDiceTag == "NormalSword" && enemyDiceTag == "APSword") &&
                    (enemyDiceTag == "NormalBow" && enemyDiceTag == "APBow"))
                {
                    ESP.e_Hp -= PSP.p_CounterAttack;
                    Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }

                //自分のダイスが剣ダイスの時かつ敵のダイスが鎧ダイスでない場合ダメージを入れてアイテムポイント＋１
                if (playerDiceTag == "APSword")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
                    {
                        ESP.e_Hp -= PSP.p_SwordAttack;
                        Debug.Log("敵に攻撃をして" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                    }
                }
                else if (playerDiceTag == "APSword" && (enemyDiceTag == "NormalArmer" && enemyDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("敵に攻撃をしたが無効化され" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }

                //自分のダイスが弓ダイスの時かつ敵のダイスが盾ダイスでない場合ダメージを入れてアイテムポイント＋１
                if (playerDiceTag == "APBow")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
                    {
                        ESP.e_Hp -= PSP.p_BowAttack;
                        Debug.Log("敵に攻撃をして" + PSP.p_BowAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                    }
                }
                else if (playerDiceTag == "APBow" && (enemyDiceTag == "NormalShield" && enemyDiceTag == "APShield"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("敵に攻撃をしたが無効化され" + PSP.p_SwordAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                }

                //自分のダイスが鎧ダイスかつ敵のダイスが剣の場合何もせず無効化してアイテムポイント＋１
                if (playerDiceTag == "APShield")
                {
                    PSP.p_AitemPoint++;
                    if (playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
                    {
                        Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
                    }
                }

                //自分のダイスが鎧ダイスかつ敵のダイスが剣の場合何もせず無効化してアイテムポイント＋１
                if (playerDiceTag == "APArmer")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APArmer" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
                    {
                        Debug.Log("敵の攻撃を無効化した、残りHP" + PSP.p_Hp);
                    }

                }

                //自分のダイスが盗みダイスの時かつ敵のアイテムポイントが１以上の場合自分のアイテムポイントを＋２敵のアイテムポイントをー１
                if (playerDiceTag == "APSteal" && ESP.e_AitemPoint > 0)
                {
                    ESP.e_AitemPoint--;
                    PSP.p_AitemPoint += 2;
                    Debug.Log("敵のアイテムポイントを1盗んだ、自分のアイテムポイントは" + PSP.p_AitemPoint);
                }

                //自分のダイスがカウンターダイスかつ敵のダイスが弓または剣のダイスの場合カウンターダメージを入れてアイテムポイント＋１
                if (playerDiceTag == "APCounter")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APCounter" &&
                        (enemyDiceTag == "NormalSword" && enemyDiceTag == "APSword") &&
                        (enemyDiceTag == "NormalBow" && enemyDiceTag == "APBow"))
                    {
                        ESP.e_Hp -= PSP.p_CounterAttack;
                        Debug.Log("敵の攻撃に反撃して" + PSP.p_CounterAttack + "ダメージ入った、敵の残りHP" + ":" + ESP.e_Hp);
                    }
                }
            }
            FCS.statusFlag = false;
        }
    }


     
    //普通の剣ダイス
    public void PlayerNormalSwordFunction(GameObject p_dice, GameObject e_dice)    
    {
     
        
    }
     

     
    //普通の弓ダイス
    public void PlayerNormalBowFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //普通の盾ダイス
    public void PlayerNormalShieldFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //普通の鎧ダイス
    public void PlayerNormalArmerFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //普通の盗みダイス
    public void PlayerNormalStealFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //普通のカウンターダイス
    public void PlayerNormalCounterFunction(GameObject p_dice, GameObject e_dice)   
    {
     
    }
     

     
    //AP剣ダイス     
    public void PlayerAPSwordFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP弓ダイス     
    public void PlayerAPBowFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP盾ダイス     
    public void PlayerAPShieldFunction(GameObject p_dice, GameObject e_dice)    
    {
    
    }
     

     
    //AP鎧ダイス     
    public void PlayerAPArmerFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP盗みダイス    
    public void PlayerAPStealFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //APカウンターダイス    
    public void PlayerAPCounterFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }

}
