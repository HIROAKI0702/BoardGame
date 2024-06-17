using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomDice : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    public GameObject DiceButton;

    //さいころのプレハブを保存するリスト
    public List<GameObject> saikoroObject;
    //生成する位置のリスト
    public List<Vector3> spawnPositions;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //生成するオブジェクトの数
    public int spawnObject = 5;

    //オブジェクト間の最小距離
    public float minDistance = 1.0f;

    //生成済みのオブジェクトの位置を保存するリスト
    private List<Vector3> spawnedPositions = new List<Vector3>();

    bool OneButtonFlag = false;

    void Start()
    {
    }

    public void OnClick()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //生成するオブジェクトの数を決定
        int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        Debug.Log(saikoroObject.Count);

        //生成されたオブジェクトの数が指定された数に達するまでループ
        for (int i = 0; i < objectsToSpawn; i++)
        {
            //指定された位置を取得
            Vector3 newPosition = spawnPositions[i];

            //リストに新しい位置を保存
            spawnedPositions.Add(newPosition);

            //ランダムなプレハブを選択して生成
            GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            Instantiate(prefabSpawn, newPosition, Quaternion.identity);

            Debug.Log(saikoroObject.Count);
            OneButtonFlag = true;
        }

        if(OneButtonFlag == true)
        {
            DiceButton.SetActive(false);
        }
    }
}

