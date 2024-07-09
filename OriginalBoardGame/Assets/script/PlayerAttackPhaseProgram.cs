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

    public int count = 0;

    public bool[] playerDiceFlagCount = new bool[5];

    public List<GameObject> playerDiceList = new List<GameObject>();
    public List<GameObject> enemyDiceList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ResolveDiceEffects()
    {
        
    }

    public void PlayerNormalSwordFunction(GameObject dice)
    {
        Debug.Log("PlayerNormalSwordFunction");

        playerDiceFlagCount[count++] = true;

        for (int i = 0; i < ERD.selectObject.Count; i++)
        {
            if(ERD.selectObject[i].tag == "NormalArmer")
            {

            }
        }

        Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);        
    }

    public void PlayerNormalShieldFunction(GameObject dice)
    {       
        Debug.Log("PlayerNormalShieldFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);
    }

    public void PlayerNormalBowFunction(GameObject dice)
    {       
        Debug.Log("PlayerNormalBowFunction");

        playerDiceFlagCount[count++] = true;


        Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp);      
    }

    public void PlayerNormalArmerFunction(GameObject dice)
    {       
        Debug.Log("PlayerNormalArmerFunction");

        playerDiceFlagCount[count++] = true;


        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp);             
    }

    public void PlayerNormalStealFunction(GameObject dice)
    {               
        Debug.Log("PlayerNormalStealFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);                      
    }

    public void PlayerNormalCounterFunction(GameObject dice)
    {        
        Debug.Log("PlayerNormalCounterFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp); 
    }

    public void PlayerAPSwordFunction(GameObject dice)
    {        
        Debug.Log("PlayerAPSwordFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�ɍU��������" + PSP.p_SwordAttack + "�_���[�W�������A�G�̎c��HP:" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);       
    }

    public void PlayerAPShieldFunction(GameObject dice)
    {       
        Debug.Log("PlayerAPShieldFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);        
    }

    public void PlayerAPBowFunction(GameObject dice)
    {       
        Debug.Log("PlayerAPBowFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�ɍU��������" + PSP.p_BowAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);       
    }

    public void PlayerAPArmerFunction(GameObject dice)
    {       
        Debug.Log("PlayerAPArmerFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̍U���𖳌��������A�c��HP" + PSP.p_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);       
    }

    public void PlayerAPStealFunction(GameObject dice)
    {
        Debug.Log("PlayerAPStealFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̃A�C�e���|�C���g��1���񂾁A�����̃A�C�e���|�C���g��" + PSP.p_AitemPoint);
    }

    public void PlayerAPCounterFunction(GameObject dice)
    {        
        Debug.Log("PlayerAPCounterFunction");

        playerDiceFlagCount[count++] = true;

        Debug.Log("�G�̍U���ɔ�������" + PSP.p_CounterAttack + "�_���[�W�������A�G�̎c��HP" + ":" + ESP.e_Hp + "�����̃A�C�e���|�C���g" + PSP.p_AitemPoint);        
    }
}
