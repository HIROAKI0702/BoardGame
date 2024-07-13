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
        //�G�̃T�C�R���̐��Ǝ����̃T�C�R���̐��������ł��邩���m�F
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

        //�����̃_�C�X�����_�C�X�̎����G�̃_�C�X���Z�_�C�X�łȂ��ꍇ�_���[�W������
        if(playerDiceTag == "NormalSword" && (enemyDiceTag != "NoromalArmer" || enemyDiceTag != "APArmer"))
        {
            ESP.e_Hp -= PSP.p_SwordAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        //�����̃_�C�X���|�_�C�X�̎����G�̃_�C�X�����_�C�X�łȂ��ꍇ�_���[�W������
        if (playerDiceTag == "NormalBow" &&(enemyDiceTag != "NormalShiel" || enemyDiceTag != "APShiel"))
        {
            ESP.e_Hp -= PSP.p_BowAttack;
            Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        //�����̃_�C�X�����݃_�C�X�̎����G�̃A�C�e���|�C���g���P�ȏ�̏ꍇ
        if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
        {
            ESP.e_AitemPoint--;
            PSP.p_AitemPoint++;
            Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
        }

        //�����̃_�C�X���J�E���^�[�_�C�X���G�̃_�C�X���|�܂��͌��̃_�C�X�̏ꍇ�J�E���^�[�_���[�W������
        if (playerDiceTag == "NoromalCounter" && 
            (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword") || 
            (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
        {
            ESP.e_Hp -= PSP.p_CounterAttack;
            Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
        }

        //�����̃_�C�X���Z�_�C�X���G�̃_�C�X�����̏ꍇ������������������
        if (playerDiceTag == "NormalArmor" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
        {
            Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
        }

        //�����̃_�C�X�����_�C�X���G�̃_�C�X���|�̏ꍇ������������������
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

        //HP���O�ȉ��ɂȂ�Ȃ��悤�ɂ���
        PSP.p_Hp = Mathf.Max(0, PSP.p_Hp);
        ESP.e_Hp = Mathf.Max(0, ESP.e_Hp);
    }
}
