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

    public void PlayerNormalSwordFunction(GameObject dice)
    {
        if(gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalSwordFunction");
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_SwordAttackFlag = true;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void PlayerNormalShieldFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log(ESP.e_BowAttackFlag);
            Debug.Log("PlayerNormalShieldFunction");
            if(ESP.e_BowAttackFlag == true)
            {
                PSP.p_Hp = ESP.e_BowAttack;
                Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
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
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }
    }

    public void PlayerNormalArmerFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log(ESP.e_SwordAttackFlag);
            Debug.Log("PlayerNormalArmerFunction");
            if (ESP.e_SwordAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_SwordAttack;
                Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
            }
            ESP.e_SwordAttackFlag = false;
        }
    }

    public void PlayerNormalStealFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {            
            if (ESP.e_AitemPoint > 0)
            {
                Debug.Log("PlayerNormalStealFunction");
                ESP.e_AitemPoint--;
                PSP.p_AitemPoint++;
                Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
            }                 
        }
    }

    public void PlayerNormalCounterFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerNormalCounterFunction");
            if(ESP.e_SwordAttackFlag == true || ESP.e_BowAttackFlag == true)
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
                Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
            }
            ESP.e_SwordAttackFlag = false;
            ESP.e_BowAttackFlag = false;
        }
    }

    public void PlayerAPSwordFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPSwordFunction");
            PSP.p_AitemPoint++;
            ESP.e_Hp -= PSP.p_SwordAttack;
            PSP.p_SwordAttackFlag = true;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP:" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPShieldFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPShieldFunction");
            PSP.p_AitemPoint++;
            if (ESP.e_BowAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_BowAttack;
            }
            ESP.e_BowAttackFlag = false;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPBowFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPBowFunction");
            PSP.p_AitemPoint++;
            ESP.e_Hp -= PSP.p_BowAttack;
            PSP.p_BowAttackFlag = true;
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPArmerFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log(ESP.e_SwordAttackFlag);
            Debug.Log("PlayerAPArmerFunction");
            PSP.p_AitemPoint++;
            if (ESP.e_SwordAttackFlag == true)
            {
                PSP.p_Hp += ESP.e_SwordAttack;
            }
            ESP.e_SwordAttackFlag = false;
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }

    public void PlayerAPStealFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            PSP.p_AitemPoint++;
            if (ESP.e_AitemPoint > 0)
            {
                PSP.p_AitemPoint++;
                ESP.e_AitemPoint--;
            }              
            Debug.Log("PlayerAPStealFunction");
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint + "�G�̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

    public void PlayerAPCounterFunction(GameObject dice)
    {
        if (gamemanager.playerAttackTurnFlag == true)
        {
            Debug.Log("PlayerAPCounterFunction");
            PSP.p_AitemPoint++;
            if (ESP.e_SwordAttackFlag == true || ESP.e_BowAttackFlag)
            {
                ESP.e_Hp -= PSP.p_CounterAttack;
            }
            ESP.e_SwordAttackFlag = false;
            ESP.e_BowAttackFlag = false;
            Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }
}
