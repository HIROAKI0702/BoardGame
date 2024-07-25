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

                //�����̃_�C�X�����_�C�X�̎����G�̃_�C�X���Z�_�C�X�łȂ��ꍇ�_���[�W������
                if (playerDiceTag == "NormalSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
                {
                    ESP.e_Hp -= PSP.p_SwordAttack;
                    Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }
                else if (playerDiceTag == "NormalSword" && (enemyDiceTag == "NormalArmer" && enemyDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }

                //�����̃_�C�X���|�_�C�X�̎����G�̃_�C�X�����_�C�X�łȂ��ꍇ�_���[�W������
                if (playerDiceTag == "NormalBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
                {
                    ESP.e_Hp -= PSP.p_BowAttack;
                    Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }
                else if (playerDiceTag == "NormalBow" && (enemyDiceTag == "NormalShield" && enemyDiceTag == "APShield"))
                {
                    PSP.p_BowAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }

                //�����̃_�C�X�����_�C�X���G�̃_�C�X���|�̏ꍇ������������������
                if (playerDiceTag == "NormalShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
                {
                    Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
                }

                //�����̃_�C�X���Z�_�C�X���G�̃_�C�X�����̏ꍇ������������������
                if (playerDiceTag == "NormalArmer" && (enemyDiceTag == "NormalSword" || enemyDiceTag == "APSword"))
                {
                    Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
                }

                //�����̃_�C�X�����݃_�C�X�̎����G�̃A�C�e���|�C���g���P�ȏ�̏ꍇ�����̃A�C�e���|�C���g���{�Q�G�̃A�C�e���|�C���g���[�P
                if (playerDiceTag == "NormalSteal" && ESP.e_AitemPoint > 0)
                {
                    ESP.e_AitemPoint--;
                    PSP.p_AitemPoint++;
                    Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
                }

                //�����̃_�C�X���J�E���^�[�_�C�X���G�̃_�C�X���|�܂��͌��̃_�C�X�̏ꍇ�J�E���^�[�_���[�W������
                if (playerDiceTag == "NormalCounter" &&
                    (enemyDiceTag == "NormalSword" && enemyDiceTag == "APSword") &&
                    (enemyDiceTag == "NormalBow" && enemyDiceTag == "APBow"))
                {
                    ESP.e_Hp -= PSP.p_CounterAttack;
                    Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }

                //�����̃_�C�X�����_�C�X�̎����G�̃_�C�X���Z�_�C�X�łȂ��ꍇ�_���[�W�����ăA�C�e���|�C���g�{�P
                if (playerDiceTag == "APSword")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APSword" && (enemyDiceTag != "NormalArmer" && enemyDiceTag != "APArmer"))
                    {
                        ESP.e_Hp -= PSP.p_SwordAttack;
                        Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                    }
                }
                else if (playerDiceTag == "APSword" && (enemyDiceTag == "NormalArmer" && enemyDiceTag == "APArmer"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }

                //�����̃_�C�X���|�_�C�X�̎����G�̃_�C�X�����_�C�X�łȂ��ꍇ�_���[�W�����ăA�C�e���|�C���g�{�P
                if (playerDiceTag == "APBow")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APBow" && (enemyDiceTag != "NormalShield" && enemyDiceTag != "APShield"))
                    {
                        ESP.e_Hp -= PSP.p_BowAttack;
                        Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                    }
                }
                else if (playerDiceTag == "APBow" && (enemyDiceTag == "NormalShield" && enemyDiceTag == "APShield"))
                {
                    PSP.p_SwordAttack = 0;
                    Debug.Log("�G�ɍU��������������������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                }

                //�����̃_�C�X���Z�_�C�X���G�̃_�C�X�����̏ꍇ�����������������ăA�C�e���|�C���g�{�P
                if (playerDiceTag == "APShield")
                {
                    PSP.p_AitemPoint++;
                    if (playerDiceTag == "APShield" && (enemyDiceTag == "NormalBow" || enemyDiceTag == "APBow"))
                    {
                        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
                    }
                }

                //�����̃_�C�X���Z�_�C�X���G�̃_�C�X�����̏ꍇ�����������������ăA�C�e���|�C���g�{�P
                if (playerDiceTag == "APArmer")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APArmer" && (enemyDiceTag == "NomalSword" || enemyDiceTag == "APSword"))
                    {
                        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
                    }

                }

                //�����̃_�C�X�����݃_�C�X�̎����G�̃A�C�e���|�C���g���P�ȏ�̏ꍇ�����̃A�C�e���|�C���g���{�Q�G�̃A�C�e���|�C���g���[�P
                if (playerDiceTag == "APSteal" && ESP.e_AitemPoint > 0)
                {
                    ESP.e_AitemPoint--;
                    PSP.p_AitemPoint += 2;
                    Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
                }

                //�����̃_�C�X���J�E���^�[�_�C�X���G�̃_�C�X���|�܂��͌��̃_�C�X�̏ꍇ�J�E���^�[�_���[�W�����ăA�C�e���|�C���g�{�P
                if (playerDiceTag == "APCounter")
                {
                    PSP.p_AitemPoint++;

                    if (playerDiceTag == "APCounter" &&
                        (enemyDiceTag == "NormalSword" && enemyDiceTag == "APSword") &&
                        (enemyDiceTag == "NormalBow" && enemyDiceTag == "APBow"))
                    {
                        ESP.e_Hp -= PSP.p_CounterAttack;
                        Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);
                    }
                }
            }
            FCS.statusFlag = false;
        }
    }


     
    //���ʂ̌��_�C�X
    public void PlayerNormalSwordFunction(GameObject p_dice, GameObject e_dice)    
    {
     
        
    }
     

     
    //���ʂ̋|�_�C�X
    public void PlayerNormalBowFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //���ʂ̏��_�C�X
    public void PlayerNormalShieldFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //���ʂ̊Z�_�C�X
    public void PlayerNormalArmerFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //���ʂ̓��݃_�C�X
    public void PlayerNormalStealFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //���ʂ̃J�E���^�[�_�C�X
    public void PlayerNormalCounterFunction(GameObject p_dice, GameObject e_dice)   
    {
     
    }
     

     
    //AP���_�C�X     
    public void PlayerAPSwordFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP�|�_�C�X     
    public void PlayerAPBowFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP���_�C�X     
    public void PlayerAPShieldFunction(GameObject p_dice, GameObject e_dice)    
    {
    
    }
     

     
    //AP�Z�_�C�X     
    public void PlayerAPArmerFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }
     

     
    //AP���݃_�C�X    
    public void PlayerAPStealFunction(GameObject p_dice, GameObject e_dice)     
    {
     
    }
     

     
    //AP�J�E���^�[�_�C�X    
    public void PlayerAPCounterFunction(GameObject p_dice, GameObject e_dice)    
    {
     
    }

}
