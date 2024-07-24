using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;
    public PlayerAttackPhaseProgram PAPP;
    public EnemyRandomDice ERD;
    public FunctionCallScript FCS;

    //�T�C�R���I�u�W�F�N�g(12��)
    public GameObject[] DiceObject;
    //�I�������_�C�X�I�u�W�F�N�g
    GameObject ChoiceDiceObject;
    //�I�������_�C�X���^�[�����I�������ɂ킫�Ɉڂ����߂�ChoiceDiceObject���i�[����I�u�W�F�N�g
    GameObject[] SetShowDice = new GameObject[5];

    public int count = 0;

    //�_�C�X��I�����̋��t���O
    bool dicechoiceFlag = false;

    //�I�������_�C�X��^�񒆂ɏo���Ƃ��̊g�嗦
    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    public Text pushEnter;

    //�_�C�X��^�񒆂ɏo�����߂̈ʒu
    private Vector3[] setpos = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };
    //�킫�Ɉړ�������Ƃ��̈ʒu
    private Vector3[] newpos = new Vector3[]
    {
        new Vector3(-7.6f,0.5f,0.0f),
        new Vector3(-6.8f,0.5f,0.0f),
        new Vector3(-6.0f,0.5f,0.0f),
        new Vector3(-5.2f,0.5f,0.0f),
        new Vector3(-4.4f,0.5f,0.0f),
    };
    //�킫�Ɉړ�������Ƃ��̊g�嗦
    private Vector3 ScalelShowDice = new Vector3(0.3f, 0.3f, 0.0f);

    //�_�C�X�̊֐����ĂԂ��߂̃^�O�̃��X�g
    public List<string> selectTag = new List<string>();
    //�_�C�X�̊֐����ĂԂ��߂̃_�C�X�̃��X�g
    public List<GameObject> selectObject = new List<GameObject>();

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
                    //�_�C�X�̊֐����ĂԂ��߂Ƀ^�O�ƃ_�C�X��������
                    selectTag.Add(tag);
                    selectObject.Add(ChoiceDiceObject);
                    count++;
                    //�ēx�N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
                    ChoiceDiceObject.GetComponent<BoxCollider2D>().enabled = false;
                    //�^�񒆂ɐ������ꂽ����������N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
                    Dice.GetComponent<BoxCollider2D>().enabled = false;
                } 
                
                if(count == 5)
                {
                    pushEnter.text = "Push To Enter";
                }
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

        if(ERD.playercallDiceFlag == true)
        {
            PlayerDiceCallTag();
            ERD.playercallDiceFlag = false;
        }
    }

    void PlayerDiceCallTag()
    {
        for(int i = 0; i < selectTag.Count; i++)
        {
            FCS.PlayerDiceCallFunction(selectTag[i], selectObject[i], ERD.selectObject[i]);
        }
    }
}
