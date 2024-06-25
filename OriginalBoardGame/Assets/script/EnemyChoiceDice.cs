using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;

    public GameObject[] DiceObject;

    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    private Vector3[] position = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };

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

    public void EnemyDiceClick()
    {
        //�N���b�N�����ꏊ�ɂɃI�u�W�F�N�g�����邩�ǂ���
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (hit2d && count < position.Length)
        {
            GameObject Dice = hit2d.collider.gameObject;

            string tag = Dice.tag;
            //Normal�܂���AP����n�܂�^�O�̎��ɓ���
            if (tag.StartsWith("Normal") || tag.StartsWith("AP"))
            {
                //�I�u�W�F�N�g�𐶐����g�傷��
                GameObject BigDice = Instantiate(Dice, position[count], Quaternion.identity);
                BigDice.transform.localScale = newScale;
                count++;
                //�ēx�N���b�N�ł��Ȃ��悤�ɃR���C�_�[�������Ă���
                BigDice.GetComponent<BoxCollider2D>().enabled = false;
                Dice.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
