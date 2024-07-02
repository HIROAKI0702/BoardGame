using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;

    public GameObject[] DiceObject;
    GameObject ChoiceDiceObject;
    GameObject[] SetShowDice = new GameObject[5];


    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    private Vector3[] setpos = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };
    private Vector3[] position = new Vector3[]
    {
        new Vector3(7.6f, -0.5f, 0.0f),
        new Vector3(6.8f, -0.5f, 0.0f),
        new Vector3(6.0f, -0.5f, 0.0f),
        new Vector3(5.2f, -0.5f, 0.0f),
        new Vector3(4.4f, -0.5f, 0.0f)
    };

    private Vector3 ScalelShowDice = new Vector3(0.3f, 0.3f, 0.0f);


    public int count = 0;

    Button btn;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator Enemy()
    {
        yield return new WaitForSeconds(3f);

        EnemyDiceChoice();

        yield break;
    }

    public void EnemyDiceChoice()
    {
        for (int i = 0; i < setpos.Length && count < setpos.Length; i++)
        {
            //�����_���Ƀ_�C�X��I��
            GameObject Dice = DiceObject[Random.Range(0, DiceObject.Length)];

            //�I�u�W�F�N�g�𐶐����g�傷��
            ChoiceDiceObject = Instantiate(Dice, setpos[count], Quaternion.identity);
            ChoiceDiceObject.transform.localScale = newScale;

            SetShowDice[count] = ChoiceDiceObject;
            count++;

            //�ēx�N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
            ChoiceDiceObject.GetComponent<BoxCollider2D>().enabled = false;
        }

        ////�������ꂽ�����̃_�C�X��G�̃^�[���ɂȂ������������悤�ɘe�Ɉړ�������
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        SetShowDice[i].transform.position = position[i];
        //        SetShowDice[i].transform.localScale = ScalelShowDice;
        //    }
        //}
    }







}
