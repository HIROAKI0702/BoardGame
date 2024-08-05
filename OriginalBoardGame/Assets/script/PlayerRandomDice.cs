using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRandomDice : MonoBehaviour
{
    public GameManager gamemanagers;
    public ChoiceDice choicedice;
    public ReRollButtonScript reroll;

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject DiceButton;
    GameObject Dice;
    //GameObject prefabSpawn;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //生成するオブジェクトの数
    public int spawnObject = 5;
    //オブジェクト間の最小距離
    public float minDistance = 1.0f;

    //リロール許可フラグ
    public bool reRollFlag = false;

    //さいころのプレハブを保存するリスト
    public List<GameObject> saikoroObject;
    //生成する位置のリスト
    public List<Vector3> spawnPositions;
    //生成済みのオブジェクトの位置を保存するリスト
    private List<Vector3> spawnedPositions = new List<Vector3>();
    //前回生成されたオブジェクトを保存するリスト
    private List<GameObject> LastTimeDice = new List<GameObject>();


    Button btn;

    public int rerollCount = 0;
    private GameObject prefabSpawn;

    void Start()
    {
        btn = GetComponent<Button>();
    }

    private void Update()
    {
        //if(gamemanagers.MyTurnFlag == true)
        //{
        //    btn.interactable = false;
        //}
    }

    public void OnClick()
    {
        SpawnObjects();
        //一度しかボタンを押せないようにする
        btn.interactable = false;      
    }

    public void SpawnObjects()
    {
        //生成するオブジェクトの数を決定
        //int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        float randomDice = Random.Range(0, 90);

        RemoveDice();

        //生成されたオブジェクトの数が指定された数に達するまでループ
        for (int i = 0; i < spawnObject - choicedice.count; i++)
        {
            //指定された位置を取得
            Vector3 newPosition = spawnPositions[i];

            //リストに新しい位置を保存
            spawnedPositions.Add(newPosition);

            ////ランダムなプレハブを選択して生成
            //prefabSpawn = saikoroObject[Random.Range(0, 12)];
            GameObject Dice = Instantiate(saikoroObject[GetRandomDice()], newPosition, Quaternion.identity);
            //GameObject Dice = Instantiate(saikoroObject[11], newPosition, Quaternion.identity);

            LastTimeDice.Add(Dice);
        }
        reRollFlag = true;    
    }

    void RemoveDice()
    {
        foreach(GameObject obj in LastTimeDice)
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
        for(int i = 0; i <　6; i++)
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
}

