using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusProgram : MonoBehaviour
{
    public int p_Hp = 100;�@�@�@�@�@//�̗�
    public int p_SwordAttack = 10;�@//���̍U����
    public int p_BowAttack = 10;�@�@//�|�̍U����
    public int p_Defense = 10;�@�@�@//�h���
    public int p_AitemPoint = 0;�@�@//�A�C�e���|�C���g
    public int p_CounterAttack = 10;//�J�E���^�[�̍U����

    public bool p_SwordAttackFlag = false;�@//���̍U������t���O
    public bool p_BowAttackFlag = false;�@�@//�|�̍U������t���O
    public bool p_CounterAttackFlag = false;//�J�E���^�[�U���̍U������t���O

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
