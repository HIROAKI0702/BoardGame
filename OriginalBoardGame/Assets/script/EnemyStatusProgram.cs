using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusProgram : MonoBehaviour
{
    public int e_Hp = 100;�@�@�@�@�@//�̗�
    public int e_SwordAttack = 10;�@//���̍U����
    public int e_BowAttack = 10;�@�@//�|�̍U����
    public int e_Defense = 10;�@�@�@//�h���
    public int e_AitemPoint = 0;�@�@//�A�C�e���|�C���g
    public int e_CounterAttack = 10;//�J�E���^�[�̍U����

    public bool e_SwordAttackFlag = false;  //���̍U������t���O
    public bool e_BowAttackFlag = false;    //�|�̍U������t���O
    public bool e_CounterAttackFlag = false;//�J�E���^�[�U���̍U������t���Oe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
