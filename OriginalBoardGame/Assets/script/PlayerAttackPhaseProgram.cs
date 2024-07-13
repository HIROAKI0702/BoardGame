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
        for(int i = 0; i < choicedice.selectObject.Count; i++)
        {
            for(int j = 0; j < ERD.selectObject.Count; j++)
            {
                StatusChange(choicedice.selectObject[i], ERD.selectObject[j]);
            }
        }
    }

    private void StatusChange(GameObject playerDice,GameObject enemyDice)
    {
        string playerDiceTag = playerDice.tag;
        string enemyDiceTag = enemyDice.tag;

        if(playerDiceTag == "NormalSword" && (enemyDiceTag != "NoromalArmer" || enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "NormalBow" &&(enemyDiceTag != "NormalShiel" || enemyDiceTag != "APShiel"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }

        if (playerDiceTag == "NoromalCounter" && 
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") || 
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "NormalArmor" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APSword" && (enemyDiceTag != "NoromalArmer" || enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_AitemPoint++;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APBow" && (enemyDiceTag != "NormalShiel" || enemyDiceTag != "APShiel"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            PSP.p_AitemPoint++;
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            PSP.p_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }

        if (playerDiceTag == "APCounter" &&
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") ||
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            PSP.p_AitemPoint++;
            Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        if (playerDiceTag == "APArmor" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
        {
            PSP.p_AitemPoint++;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            PSP.p_AitemPoint++;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }
    }
}
