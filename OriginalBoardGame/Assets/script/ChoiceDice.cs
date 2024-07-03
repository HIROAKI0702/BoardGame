using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;
    public AtackPhaseProgram APP;

    //�T�C�R���I�u�W�F�N�g(12��)
    public GameObject[] DiceObject;
    GameObject ChoiceDiceObject;
    GameObject[] SetShowDice = new GameObject[5];

    public int count = 0;

    //�_�C�X��I�����̋��t���O
    bool dicechoiceFlag = false;

    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    private Vector3[] setpos = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };
    private Vector3[] newpos = new Vector3[]
    {
        new Vector3(-7.6f,0.5f,0.0f),
        new Vector3(-6.8f,0.5f,0.0f),
        new Vector3(-6.0f,0.5f,0.0f),
        new Vector3(-5.2f,0.5f,0.0f),
        new Vector3(-4.4f,0.5f,0.0f),
    };
    private Vector3 ScalelShowDice = new Vector3(0.3f, 0.3f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            dicechoiceFlag = true;
        }

        if (dicechoiceFlag == true)
        {
            //�N���b�N�����ꏊ�ɂɃI�u�W�F�N�g�����邩�ǂ���
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d && count < setpos.Length)
            {
                GameObject Dice = hit2d.collider.gameObject;

                string tag = Dice.tag;
                //Normal�܂���AP����n�܂�^�O�̎��ɓ���
                if (tag.StartsWith("Normal") || tag.StartsWith("AP"))
                {
                    //�I�u�W�F�N�g�𐶐����g�傷��
                    ChoiceDiceObject = Instantiate(Dice, setpos[count], Quaternion.identity);
                    ChoiceDiceObject.transform.localScale = newScale;
                    Destroy(Dice);

                    SetShowDice[count] = ChoiceDiceObject;
                    count++;
                    //�ēx�N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
                    ChoiceDiceObject.GetComponent<BoxCollider2D>().enabled = false;
                    //�^�񒆂ɐ������ꂽ����������N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
                    Dice.GetComponent<BoxCollider2D>().enabled = false;             
                }
                //���ꂼ��̃_�C�X�̓������Ăяo��
                CallDiceTag(tag);
            }          
        }
        //�������ꂽ�����̃_�C�X��G�̃^�[���ɂȂ������������悤�ɘe�Ɉړ�������
        if (gamemanager.ReturnPushFlag == true)
        {
            for (int i = 0; i < count; i++)
            {
                SetShowDice[i].transform.position = newpos[i];
                SetShowDice[i].transform.localScale = ScalelShowDice;
            }
            gamemanager.ReturnPushFlag = false;
        }
        dicechoiceFlag = false;        
    }

    public void CallDiceTag(string tag)
    {
        switch(tag)
        {
            case "NormalSword":
                APP.NormalSwordFunction();
                break;
            case "NormalShield":
                APP.NormalShieldFunction();
                break;
            case "NormalBow":
                APP.NormalBowFunction();
                break;
            case "NormalArmer":
                APP.NormalArmerFunction();
                break;
            case "NormalSteal":
                APP.NormalStealFunction();
                break;
            case "NormalCounter":
                APP.NormalCounterFunction();
                break;
            case "APSword":
                APP.APSwordFunction();
                break;
            case "APShield":
                APP.APShieldFunction();
                break;
            case "APBow":
                APP.APBowFunction();
                break;
            case "APArmer":
                APP.APArmerFunction();
                break;
            case "APSteal":
                APP.APStealFunction();
                break;
            case "APCounter":
                APP.APCounterFunction();
                break;
        }
    }
}
