using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public PlayerStatusProgram PSP;
    public EnemyStatusProgram ESP;

    //public GameObject HPObj;

    //Player
    public Text PlayerHpText;
    public Text PlayerAPText;
    //Enemy
    public Text EnemyHpText;
    public Text EnemyAPText;

    // Start is called before the first frame update
    void Start()
    {
        //HpText = HPObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHpText.text = "HP:" + PSP.p_Hp;
        EnemyHpText.text = "HP:" + ESP.e_Hp;

        PlayerAPText.text = "AP:" + PSP.p_AitemPoint;
        EnemyAPText.text = "AP:" + ESP.e_AitemPoint;
    }
}
