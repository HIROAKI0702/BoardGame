using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;
    public GameObject[] DiceObject;

    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    public int count = 0;

    GameObject[] SetShowDice = new GameObject[5];

    private Vector3[] position = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };
    private Vector3[] newpos = new Vector3[]
    {
        new Vector3(-7.5f,.3f,0.0f),
        new Vector3(-6.6f,.3f,0.0f),
        new Vector3(-5.7f,.3f,0.0f),
        new Vector3(-4.8f,.3f,0.0f),
        new Vector3(-3.9f,.3f,0.0f),
    };
    private Vector3 ScalelShowDice = new Vector3(0.35f, 0.35f, 0.0f);

    private bool DiceMoveFlag = false;

    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            DiceClick();
        }

        if (gamemanager.ReturnPushFlag == true)
        {
            Debug.Log(gamemanager.ReturnPushFlag);
            DiceMoveFlag = true;
            gamemanager.ReturnPushFlag = false;
        }
    }

    public void DiceClick()
    {  
        //クリックした場所ににオブジェクトがあるかどうか
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
  
        if (hit2d  && count < position.Length)
        {
            GameObject Dice = hit2d.collider.gameObject;

            string tag = Dice.tag;
            //NormalまたはAPから始まるタグの時に動く
            if(tag.StartsWith("Normal")||tag.StartsWith("AP"))
            {
                //オブジェクトを生成し拡大する
                GameObject ChoiceDice = Instantiate(Dice, position[count], Quaternion.identity);
                ChoiceDice.transform.localScale = newScale;
                count++;
                //再度クリックできないようにコライダーを消しておく
                ChoiceDice.GetComponent<BoxCollider2D>().enabled = false;
                //真ん中に生成されたさいころをクリックできないようにコライダーを消しておく
                Dice.GetComponent<BoxCollider2D>().enabled = false;

                if (DiceMoveFlag == true)
                {
                    Debug.Log(DiceMoveFlag);
                    for (int i = 0; i < count; i++)
                    {
                        SetShowDice[i] = ChoiceDice;
                        SetShowDice[i].transform.position = newpos[count - 1];
                        SetShowDice[i].transform.localScale = ScalelShowDice;
                        Debug.Log(i);
                    }
                }
            }
        }      
    }
}
