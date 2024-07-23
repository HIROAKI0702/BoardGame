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

        //�����̃_�C�X�����_�C�X�̎����G�̃_�C�X���Z�_�C�X�łȂ��ꍇ�_���[�W������
        if (playerDiceTag == "NormalSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        //�����̃_�C�X���|�_�C�X�̎����G�̃_�C�X�����_�C�X�łȂ��ꍇ�_���[�W������
        if (playerDiceTag == "NormalBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }
        else
        {
            PSP.p_BowAttack = 0;
            Debug.Log("a");
        }

        //�����̃_�C�X�����݃_�C�X�̎����G�̃A�C�e���|�C���g���P�ȏ�̏ꍇ
        if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }

        //�����̃_�C�X���J�E���^�[�_�C�X���G�̃_�C�X���|�܂��͌��̃_�C�X�̏ꍇ�J�E���^�[�_���[�W������
        if (playerDiceTag == "NormalCounter" &&
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") ||
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        //�����̃_�C�X���Z�_�C�X���G�̃_�C�X�����̏ꍇ������������������
        if (playerDiceTag == "NormalArmer" && (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        //�����̃_�C�X�����_�C�X���G�̃_�C�X���|�̏ꍇ������������������
        if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        if (playerDiceTag == "APSword")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
            {
                ESP.e_Hp -= PSP.p_SwordAttack;
                Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
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
                Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
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
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }

        if (playerDiceTag == "APCounter")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APCounter" && 
                (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") || 
                (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
                Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
            }          
        }

        if (playerDiceTag == "APArmer")
        {
            PSP.p_AitemPoint++;

            if (playerDiceTag == "APArmer" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
            {
                Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
            }
            
        }

        if (playerDiceTag == "APShield")
        {
            PSP.p_AitemPoint++;
            if(playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
            {
                Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
            }
        }

        //HP���O�ȉ��ɂȂ�Ȃ��悤�ɂ���
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
            Debug.Log("�G�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }
        else
        {
            PSP.p_SwordAttack = 0;
        }

        if (enemyDiceTag == "NormalBow" && (playerDiceTag != "NormalShield" && playerDiceTag != "APShield"))
        {
            PSP.p_Hp -= ESP.e_BowAttack;
            Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }
        else
        {
            PSP.p_BowAttack = 0;
        }

        if (enemyDiceTag == "NormalSteal" && PSP.p_AitemPoint > 0)
        {
            PSP.p_AitemPoint--;
            ESP.e_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�G�̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "NormalCounter" &&
            (playerDiceTag == "NormalSword" || playerDiceTag == "APSword" ||
            playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            PSP.p_Hp -= ESP.e_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
        }

        if (enemyDiceTag == "NormalArmer" && (playerDiceTag == "NormalSword" || playerDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
        }

        if (enemyDiceTag == "NormalShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
        {
            Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + ESP.e_Hp);
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
                Debug.Log("�G�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
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
            Debug.Log("�G�̃A�C�e���|�C���g��2���񂾁A�G�̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
        }

        if (enemyDiceTag == "APCounter")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APCounter" && 
                (playerDiceTag == "NormalSword" || playerDiceTag == "APSword") || 
                (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
                Debug.Log("�G�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP:" + PSP.p_Hp);
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

        if (enemyDiceTag == "APShield")
        {
            ESP.e_AitemPoint++;

            if (enemyDiceTag == "APShield" && (playerDiceTag == "NormalBow" || playerDiceTag == "APBow"))
            {
                Debug.Log("�G�̍U���𖳌��������A�G�̎c��HP" + PSP.p_Hp);
            }
        }

        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }
}
