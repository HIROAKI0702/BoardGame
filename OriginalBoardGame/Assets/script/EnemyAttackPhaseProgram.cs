using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Debug.Log("�v���C���[�ɍU��������" + ESP.e_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp);
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
                Debug.Log("�v���C���[�̍U�����󂯂�5�_���[�W�󂯂��A�c��HP" + ESP.e_Hp);
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
            Debug.Log("�v���C���[�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp);
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
                Debug.Log("�v���C���[�̍U�����󂯂�5�_���[�W�󂯂��A�c��HP" + ESP.e_Hp);
            }
            PSP.p_SwordAttackFlag = false;
        }
    }

    public void EnemyNormalStealFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            if (PSP.p_AitemPoint >= 1)
            {
                Debug.Log("EnemyNormalStealFunction");
                PSP.p_AitemPoint--;
                ESP.e_AitemPoint++;
                Debug.Log("�v���C���[�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + ESP.e_AitemPoint);
            }
        }
    }

    public void EnemyNormalCounterFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyNormalCounterFunction");
            if (PSP.p_SwordAttackFlag == true || PSP.p_BowAttackFlag)
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
                Debug.Log("�v���C���[�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp);
            }
            PSP.p_CounterAttackFlag = false;
        }
    }

    public void EnemyAPSwordFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPSwordFunction");
            PSP.p_Hp -= ESP.e_SwordAttack;
            ESP.e_SwordAttackFlag = true;
            ESP.e_AitemPoint++;
            Debug.Log("�v���C���[�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPShieldFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPShieldFunction");
            if (PSP.p_BowAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_BowAttack;
            }
            ESP.e_AitemPoint++;
            PSP.p_BowAttackFlag = false;
            Debug.Log("�v���C���[�̍U����5�_���[�W�󂯂��A�c��HP" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPBowFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPBowFunction");
            PSP.p_Hp -= ESP.e_BowAttack;
            ESP.e_BowAttackFlag = true;
            ESP.e_AitemPoint++;
            Debug.Log("�v���C���[�ɍU��������" + ESP.e_BowAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPArmerFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPArmerFunction");
            if (PSP.p_SwordAttackFlag == true)
            {
                ESP.e_Hp += PSP.p_SwordAttack;
            }
            ESP.e_AitemPoint++;
            PSP.p_SwordAttackFlag = false;
            Debug.Log("�v���C���[�̍U����5�_���[�W�󂯂��A�c��HP" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

    public void EnemyAPStealFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPStealFunction");
            if (PSP.p_AitemPoint >= 1)
            {
                ESP.e_AitemPoint++;
                PSP.p_AitemPoint--;
            }
            ESP.e_AitemPoint++;
            Debug.Log("�v���C���[�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + ESP.e_AitemPoint + "�v���C���[�̃A�C�e���|�C���g" + PSP.p_AitemPoint);
        }
    }

    public void EnemyAPCounterFunction(GameObject dice)
    {
        if (gamemanager.enemyAttackTurnFlag == true)
        {
            Debug.Log("EnemyAPCounterFunction");
            if (PSP.p_SwordAttackFlag == true || PSP.p_BowAttackFlag)
            {
                PSP.p_Hp -= ESP.e_CounterAttack;
            }
            ESP.e_AitemPoint++;
            PSP.p_CounterAttackFlag = false;
            Debug.Log("�v���C���[�̍U���ɔ�������" + ESP.e_CounterAttack + "�_���[�W�������A�v���C���[�̎c��HP" + ":" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + ESP.e_AitemPoint);
        }
    }

}
