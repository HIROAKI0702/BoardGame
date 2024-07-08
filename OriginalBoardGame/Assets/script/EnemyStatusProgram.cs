using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusProgram : MonoBehaviour
{
    public int e_Hp = 100;　　　　　//体力
    public int e_SwordAttack = 10;　//剣の攻撃力
    public int e_BowAttack = 10;　　//弓の攻撃力
    public int e_Defense = 10;　　　//防御力
    public int e_AitemPoint = 0;　　//アイテムポイント
    public int e_CounterAttack = 10;//カウンターの攻撃力

    public bool e_SwordAttackFlag = false;  //剣の攻撃判定フラグ
    public bool e_BowAttackFlag = false;    //弓の攻撃判定フラグ
    public bool e_CounterAttackFlag = false;//カウンター攻撃の攻撃判定フラグe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
