using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomDice : MonoBehaviour
{
    public GameManager gamemanager;
    public EnemyAttackPhaseProgram EAPP;
    public FunctionCallScript FCS;

    public GameObject Stage1;
    public GameObject Stage2;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //生成するオブジェクトの数
    public int spawnObject = 5;
    public int count = 0;

    //オブジェクト間の最小距離
    public float minDistance = 1.0f;

    //ダイスに対応した関数を呼ぶためのフラグ
    public bool playercallDiceFlag = false;
    public bool enemycallDiceFlag = false;

    //さいころのプレハブを保存するリスト
    public List<GameObject> saikoroObject;
    //生成する位置のリスト
    public List<Vector3> spawnPositions;
    //生成済みのオブジェクトの位置を保存するリスト
    private List<Vector3> spawnedPositions = new List<Vector3>();
    //前回生成されたオブジェクトを保存するリスト
    private List<GameObject> LastTimeDice = new List<GameObject>();
    //ダイスに対応する関数を保持するリスト
    private List<System.Action> diceFunction = new List<System.Action>();
    //ダイスの関数を呼ぶためのタグのリスト
    public List<string> selectTag = new List<string>();
    //ダイスの関数を呼ぶためのダイスのリスト
    public List<GameObject> selectObject = new List<GameObject>();

    //ダイスの移動先の位置のリスト
    public List<Vector3> movePosition;
    public List<Vector3> setPosition;


    private Vector3 NewScale = new Vector3(0.5f, 0.5f, 0.5f);
    private Vector3 SetScale = new Vector3(0.3f, 0.3f, 0.3f);


    void Start()
    {
       
    }

    private void Update()
    {
        if (enemycallDiceFlag == true)
        {
            EnemyDiceCallTag();
            enemycallDiceFlag = false;
        }
    }

    public void EnemyTurn()
    {
        if (gamemanager.MyTurnFlag == false)
        {
            RemoveDice();

            //生成するオブジェクトの数を決定
            //int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

            //生成されたオブジェクトの数が指定された数に達するまでループ
            for (int i = 0; i < spawnObject; i++)
            {
                //指定された位置を取得
                Vector3 newPosition = spawnPositions[i];

                //リストに新しい位置を保存
                spawnedPositions.Add(newPosition);
                
                count++;

                //ランダムなプレハブを選択して生成
                //GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
                GameObject Dice = Instantiate(saikoroObject[GetRandomDice()], newPosition, Quaternion.identity);

                string tag = Dice.tag;

                LastTimeDice.Add(Dice);
                //ダイスの関数を呼ぶためにタグとダイスを加える
                selectTag.Add(tag);
                selectObject.Add(Dice);

                //触れないようにコライダーを消しておく
                Dice.GetComponent<BoxCollider2D>().enabled = false;
            }
            StartCoroutine(MoveDice());          
        }
    }

    void RemoveDice()
    {
        //リロールで再生成する際に、前のダイスを消す
        foreach (GameObject obj in LastTimeDice)
        {
            Destroy(obj);
        }
        LastTimeDice.Clear();
    }

    int GetRandomDice()
    {
        int[] weight = new int[20];
        int index = 0;

        //0～5の範囲で選ばれる
        for (int i = 0; i < 6; i++)
        {
            weight[index++] = i;
            weight[index++] = i;//2倍にする
        }
        for (int i = 6; i < saikoroObject.Count; i++)
        {
            weight[index++] = i;
        }

        return weight[Random.Range(0, weight.Length)];

    }

    void EnemyDiceCallTag()
    {
        //タグの個数分（5個）
        for (int i = 0; i < selectTag.Count; i++)
        {
            EAPP.CompareDice();
        }
    }

    IEnumerator MoveDice()
    {
        for(int i=0; i < LastTimeDice.Count; i++)
        {
            if(i < movePosition.Count)
            {
                Vector3 startPosition = LastTimeDice[i].transform.position;
                Vector3 targetPosition = movePosition[i];

                float elapsedTime = 0f;
                float duration = 1f;

                while(elapsedTime < duration)
                {
                    //線形補完により２転換の距離を滑らかに移動させる　始点　　　　　 終点　　　　　　補完の割合
                    LastTimeDice[i].transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                    LastTimeDice[i].transform.localScale = NewScale;//サイズ変更
                    elapsedTime += Time.deltaTime;
                    yield return null;
                }

                LastTimeDice[i].transform.position = targetPosition;
            }
        }

        StartCoroutine(TurnEndMoveDice());
    }

    IEnumerator TurnEndMoveDice()
    {
        for (int i = 0; i < LastTimeDice.Count; i++)
        {
            if (i < setPosition.Count)
            {
                Vector3 startPosition = LastTimeDice[i].transform.position;
                Vector3 targetPosition = setPosition[i];

                float elapsedTime = 0f;
                float duration = 1f;

                while (elapsedTime < duration)
                {
                    LastTimeDice[i].transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                    LastTimeDice[i].transform.localScale = SetScale;
                    elapsedTime += Time.deltaTime;
                    yield return null;
                }

                LastTimeDice[i].transform.position = targetPosition;
            }
        }
        gamemanager.MyTurnFlag = true;
        playercallDiceFlag = true;
        enemycallDiceFlag = true;
    }
}

