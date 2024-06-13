using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomDice : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    //さいころのプレハブを保存するリスト
    public List<GameObject> saikoroObject;
    //さいころをスポーンさせるポジションを保存するリスト
    public List<Vector3> DiceSpawnPosition;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //生成するオブジェクトの数
    public int spawnObject = 5;

    //オブジェクト間の最小距離
    public float minDistanceBetweenObjects = 1.0f;

    //生成済みのオブジェクトの位置を保存するリスト
    private List<Vector3> spawnedPositions = new List<Vector3>();

    void Start()
    {
        //SpawnObjects();
    }

    public void OnClick()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //重なった時にずらす処理が必要

        //生成されたオブジェクトの数を追跡する変数
        int objectSpawned = 0;

        //int objectsToSpawn = Mathf.Min(spawnedPositions.Count, saikoroObject.Count); // 生成するオブジェクトの数を決定

        //生成されたオブジェクトの数が指定された数に達するまでループ
        while (objectSpawned < spawnObject)
        {
            //Vector型のnewPositionにランダムのポジションを取得する関数を呼ぶ
            Vector3 newPosition = GetRandomPosition(minPosition, maxPosition);

            spawnedPositions.Add(newPosition);

           
            //ランダムなプレハブを選択して生成
            GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            Instantiate(prefabSpawn, newPosition, Quaternion.identity);

            objectSpawned++; //生成されたオブジェクトの数を増やす)
                    
        }
    }

    //範囲内のランダムな位置を計算
    Vector3 GetRandomPosition(Vector3 min, Vector3 max)
    {
        return new Vector3(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y),
            Random.Range(min.z, max.z)
        );
    }
}

