using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAttackPhaseProgram : MonoBehaviour
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
        // �v���C���[�ƓG�̃T�C�R���̐��������ł��邱�Ƃ��m�F
        int diceCount = Mathf.Min(choicedice.selectObject.Count, ERD.selectObject.Count);

        for (int i = 0; i < diceCount; i++)
        {
            StatusChange(choicedice.selectObject[i], ERD.selectObject[i]);
        }
    }

    private void StatusChange(GameObject playerDice, GameObject enemyDice)
    {
        string playerDiceTag = playerDice.tag;
        string enemyDiceTag = enemyDice.tag;

        if (enemyDiceTag == "NormalSword" && (playerDiceTag != "NoromalArmer" || playerDiceTag != "APArmer"))
        {
            PSP.p_Hp -= ESP.e_SwordAttack;
            Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�G�̎c��HP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "NormalBow" && (playerDiceTag != "NormalShiel" || playerDiceTag != "APShiel"))
        {
            PSP.p_Hp -= ESP.e_BowAttack;
            Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�G�̎c��HP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "NormalSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "NoromalCounter" &&
            (playerDiceTag == "NormalSword" || playerDiceTag == "APSword") ||
            (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            PSP.p_Hp -= ESP.e_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�G�̎c��HP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "NormalArmor" && (playerDiceTag == "NomalSword" || playerDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + ESP.e_Hp);
        }

        if (enemyDiceTag == "NormalShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + ESP.e_Hp);
        }

        if (enemyDiceTag == "APSword" && (playerDiceTag != "NoromalArmer" || playerDiceTag != "APArmer"))
        {
            PSP.p_Hp -= ESP.e_SwordAttack;
            ESP.e_AitemPoint++;
            Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + PSP.p_Hp);
        }

        if (enemyDiceTag == "APBow" && (playerDiceTag != "NormalShiel" || playerDiceTag != "APShiel"))
        {
            PSP.p_Hp -= ESP.e_BowAttack;
            ESP.e_AitemPoint++;
            Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + PSP.p_Hp);
        }

        if (enemyDiceTag == "APSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint++;
            ESP.e_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "APCounter" &&
            (playerDiceTag == "NormalSword" || playerDiceTag == "APSword") ||
            (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            PSP.p_Hp -= ESP.e_CounterAttack;
            ESP.e_AitemPoint++;
            Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�G�̎c��HP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "APArmor" && (playerDiceTag == "NomalSword" || playerDiceTag == "APSword"))
        {
            ESP.e_AitemPoint++;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        if (enemyDiceTag == "APShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            ESP.e_AitemPoint++;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        //HP���O�ȉ��ɂȂ�Ȃ��悤�ɂ���
        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }    
}
