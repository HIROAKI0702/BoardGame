using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusProgram : MonoBehaviour
{
    public int p_Hp = 100;　　　　　//体力
    public int p_SwordAttack = 10;　//剣の攻撃力
    public int p_BowAttack = 10;　　//弓の攻撃力
    public int p_Defense = 10;　　　//防御力
    public int p_AitemPoint = 0;　　//アイテムポイント
    public int p_CounterAttack = 10;//カウンターの攻撃力

    public bool p_SwordAttackFlag = false;　//剣の攻撃判定フラグ
    public bool p_BowAttackFlag = false;　　//弓の攻撃判定フラグ
    public bool p_CounterAttackFlag = false;//カウンター攻撃の攻撃判定フラグ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
