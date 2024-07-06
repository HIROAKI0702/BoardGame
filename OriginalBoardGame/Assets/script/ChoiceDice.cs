using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceDice : MonoBehaviour
{
    public GameManager gamemanager;
    public AtackPhaseProgram APP;
    public EnemyRandomDice ERD;

    //サイコロオブジェクト(12個)
    public GameObject[] DiceObject;
    //選択したダイスオブジェクト
    GameObject ChoiceDiceObject;
    //選択したダイスをターンが終わった後にわきに移すためにChoiceDiceObjectを格納するオブジェクト
    GameObject[] SetShowDice = new GameObject[5];

    //
    public int count = 0;

    //ダイスを選択時の許可フラグ
    bool dicechoiceFlag = false;

    //選択したダイスを真ん中に出すときの拡大率
    public Vector3 newScale = new Vector3(0.5f, 0.5f, 0.5f);

    //ダイスを真ん中に出すための位置
    private Vector3[] setpos = new Vector3[]
    {
        new Vector3(-3.2f, 0.23f, 10),
        new Vector3(-1.58f, 0.23f, 10),
        new Vector3(0f, 0.23f, 10),
        new Vector3(1.58f, 0.23f, 10),
        new Vector3(3.2f, 0.23f, 10)
    };
    //わきに移動させるときの位置
    private Vector3[] newpos = new Vector3[]
    {
        new Vector3(-7.6f,0.5f,0.0f),
        new Vector3(-6.8f,0.5f,0.0f),
        new Vector3(-6.0f,0.5f,0.0f),
        new Vector3(-5.2f,0.5f,0.0f),
        new Vector3(-4.4f,0.5f,0.0f),
    };
    //わきに移動させるときの拡大率
    private Vector3 ScalelShowDice = new Vector3(0.3f, 0.3f, 0.0f);

    //関数を呼ぶためのタグのリスト
    private List<string> selectTag = new List<string>();
    //関数を呼ぶためのダイスのリスト
    private List<GameObject> selectObject = new List<GameObject>();

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
            //クリックした場所ににオブジェクトがあるかどうか
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d && count < setpos.Length)
            {
                GameObject Dice = hit2d.collider.gameObject;

                string tag = Dice.tag;
                //NormalまたはAPから始まるタグの時に動く
                if (tag.StartsWith("Normal") || tag.StartsWith("AP"))
                {
                    //オブジェクトを生成し拡大する
                    ChoiceDiceObject = Instantiate(Dice, setpos[count], Quaternion.identity);
                    ChoiceDiceObject.transform.localScale = newScale;
                    Destroy(Dice);

                    SetShowDice[count] = ChoiceDiceObject;
                    selectTag.Add(tag);
                    selectObject.Add(ChoiceDiceObject);
                    count++;
                    //再度クリックできないようにコライダーを消しておく
                    ChoiceDiceObject.GetComponent<BoxCollider2D>().enabled = false;
                    //真ん中に生成されたさいころをクリックできないようにコライダーを消しておく
                    Dice.GetComponent<BoxCollider2D>().enabled = false;

                    if(count == 5)
                    {
                        //それぞれのダイスの動きを呼び出す
                        ERD.callDiceFlag = true;
                    }
                }           
            }          
        }
        //生成された自分のダイスを敵のターンになった後も見えるように脇に移動させる
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

        if(ERD.callDiceFlag == true)
        {
            CallDiceTag();
           ERD.callDiceFlag = false;
        }
    }

    void CallDiceTag()
    {
        for(int i = 0; i < selectTag.Count; i++)
        {
            CallDiceFunction(selectTag[i], selectObject[i]);
        }
    }

    public void CallDiceFunction(string tag, GameObject dice)
    {
        switch(tag)
        {
            case "NormalSword":
                APP.NormalSwordFunction(dice);
                break;
            case "NormalShield":
                APP.NormalShieldFunction(dice);
                break;
            case "NormalBow":
                APP.NormalBowFunction(dice);
                break;
            case "NormalArmer":
                APP.NormalArmerFunction(dice);
                break;
            case "NormalSteal":
                APP.NormalStealFunction(dice);
                break;
            case "NormalCounter":
                APP.NormalCounterFunction(dice);
                break;
            case "APSword":
                APP.APSwordFunction(dice);
                break;
            case "APShield":
                APP.APShieldFunction(dice);
                break;
            case "APBow":
                APP.APBowFunction(dice);
                break;
            case "APArmer":
                APP.APArmerFunction(dice);
                break;
            case "APSteal":
                APP.APStealFunction(dice);
                break;
            case "APCounter":
                APP.APCounterFunction(dice);
                break;
        }
    }
}
