using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackPhaseProgram : MonoBehaviour
{
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;
    public ChoiceDice choicedice;
    public EnemyRandomDice ERD;
    public StatusChange SC;
    public PlayerAttackPhaseProgram PAPP;
    public FunctionCallScript FCS;

    string playerDiceTag;
    string enemyDiceTag;

    public int e_count;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(FCS.statusFlag == true)
        {
            for(int i = 0; i < 1; i++)
            {
                if (enemyDiceTag == "NormalSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
                {
                    PSP.p_Hp -= ESP.e_SwordAttack;
                    Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                }
                else if (enemyDiceTag == "NormalSword" && (playerDiceTag == "NormalArmer" && playerDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
                }

                if (enemyDiceTag == "NormalBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
                {
                    PSP.p_Hp -= ESP.e_BowAttack;
                    Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                }
                else if (enemyDiceTag == "NormalBow" && (playerDiceTag == "NormalShield" && playerDiceTag == "APShield"))
                {
                    PSP.p_BowAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
                }

                if (enemyDiceTag == "NormalShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
                {
                    Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
                }

                if (enemyDiceTag == "NormalArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
                {
                    Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
                }

                if (enemyDiceTag == "NormalSteal" && PSP.p_AitemPoint > 0)
                {
                    PSP.p_AitemPoint--;
                    ESP.e_AitemPoint++;
                    Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�G�̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
                }

                if (enemyDiceTag == "NormalCounter" &&
                   (playerDiceTag == "NormalSword" && playerDiceTag == "APSword" &&
                    playerDiceTag == "NormalBow" && playerDiceTag == "APBow"))
                {
                    PSP.p_Hp -= ESP.e_CounterAttack;
                    Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                }

                if (enemyDiceTag == "APSword")
                {
                    ESP.e_AitemPoint++;

                    if (enemyDiceTag == "APSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
                    {
                        PSP.p_Hp -= ESP.e_SwordAttack;
                        Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                    }
                }
                else if (enemyDiceTag == "APSword" && (playerDiceTag == "NormalArmer" && playerDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
                }

                if (enemyDiceTag == "APBow")
                {
                    ESP.e_AitemPoint++;

                    if (enemyDiceTag == "APBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
                    {
                        PSP.p_Hp -= ESP.e_BowAttack;
                        Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                    }
                }
                else if (enemyDiceTag == "APBow" && (playerDiceTag == "NormalShield" && playerDiceTag == "APShield"))
                {
                    PSP.p_BowAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
                }

                if (enemyDiceTag == "APShield")
                {
                    ESP.e_AitemPoint++;

                    if (enemyDiceTag == "APShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
                    {
                        Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + PSP.p_Hp);
                    }
                }

                if (enemyDiceTag == "APArmer")
                {
                    ESP.e_AitemPoint++;

                    if (enemyDiceTag == "APArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
                    {
                        Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + PSP.p_Hp);
                    }
                }

                if (enemyDiceTag == "APSteal" && PSP.p_AitemPoint > 0)
                {
                    PSP.p_AitemPoint--;
                    ESP.e_AitemPoint += 2;
                    Debug.Log("�G�̃A�C�e���|�C���g��2���񂾁A�G�̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
                }

                if (enemyDiceTag == "APCounter")
                {
                    ESP.e_AitemPoint++;

                    if (enemyDiceTag == "APCounter" &&
                        (playerDiceTag == "NormalSword" && playerDiceTag == "APSword") &&
                        (playerDiceTag == "NormalBow" && playerDiceTag == "APBow"))
                    {
                        PSP.p_Hp -= ESP.e_CounterAttack;
                        Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
                    }
                }
            }
            FCS.statusFlag = false;
        }
    }

    public void EnemyNormalSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
        {
            PSP.p_Hp -= ESP.e_SwordAttack;
            Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }
        else if(enemyDiceTag == "NormalSword" && (playerDiceTag == "NormalArmer" && playerDiceTag == "APArmer"))
        {
            PSP.p_SwordAttack = 0;
            Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void EnemyNormalBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
        {
            PSP.p_Hp -= ESP.e_BowAttack;
            Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }
        else if (enemyDiceTag == "NormalBow" && (playerDiceTag == "NormalShield" && playerDiceTag == "APShield"))
        {
            PSP.p_BowAttack = 0;
            Debug.Log("�G�ɍU��������������������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void EnemyNormalShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
        }
    }

    public void EnemyNormalArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
        }
    }

    public void EnemyNormalStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�G�̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
        }
    }

    public void EnemyNormalCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "NormalCounter" &&
            (playerDiceTag == "NormalSword" && playerDiceTag == "APSword" &&
            playerDiceTag == "NormalBow" && playerDiceTag == "APBow"))
        {
            PSP.p_Hp -= ESP.e_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }
    }

    public void EnemyAPSwordFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APSword")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APSword" && (playerDiceTag != "NormalArmer" && playerDiceTag != "APArmer"))
            {
                PSP.p_Hp -= ESP.e_SwordAttack;
                Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
            }
        }
        else if (enemyDiceTag == "APSword" && (playerDiceTag == "NormalArmer" && playerDiceTag == "APArmer"))
        {
            PSP.p_SwordAttack = 0;
            Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void EnemyAPBowFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APBow")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
            {
                PSP.p_Hp -= ESP.e_BowAttack;
                Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
            }
        }
        else if (enemyDiceTag == "APBow" && (playerDiceTag == "NormalShield" && playerDiceTag == "APShield"))
        {
            PSP.p_BowAttack = 0;
            Debug.Log("�G�ɍU��������������������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void EnemyAPShieldFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APShield")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
            {
                Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + PSP.p_Hp);
            }
        }
    }

    public void EnemyAPArmerFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APArmer")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
            {
                Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + PSP.p_Hp);
            }
        }
    }

    public void EnemyAPStealFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint += 2;
            Debug.Log("�G�̃A�C�e���|�C���g��2���񂾁A�G�̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }
    }

    public void EnemyAPCounterFunction(GameObject p_dice, GameObject e_dice)
    {
        playerDiceTag = p_dice.tag;
        enemyDiceTag = e_dice.tag;

        if (enemyDiceTag == "APCounter")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APCounter" &&
                (playerDiceTag == "NormalSword" && playerDiceTag == "APSword") &&
                (playerDiceTag == "NormalBow" && playerDiceTag == "APBow"))
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
                Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
            }
        }
    }   
}