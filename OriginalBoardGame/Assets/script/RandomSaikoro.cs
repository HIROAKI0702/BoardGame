using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSaikoro : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    public List<GameObject> saikoroObject;

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
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //生成されたオブジェクトの数を追跡する変数
        int objectsSpawned = 0;

        //生成されたオブジェクトの数が指定された数に達するまでループ
        while (objectsSpawned < spawnObject) 
        {
            Vector3 newPosition = GetRandomPosition(minPosition, maxPosition);
            bool validPosition = IsPositionValid(newPosition, minDistanceBetweenObjects);

            if (validPosition)
            {
                spawnedPositions.Add(newPosition);

                //ランダムなプレハブを選択して生成
                GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
                Instantiate(prefabSpawn, newPosition, Quaternion.identity);

                objectsSpawned++; //生成されたオブジェクトの数を増やす
            }
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

    // 生成された位置が他のオブジェクトの位置と重ならないかを確認
    bool IsPositionValid(Vector3 position, float minDistance)
    {
        foreach (Vector3 spawnedPosition in spawnedPositions)
        {
            if (Vector3.Distance(position, spawnedPosition) < minDistance)
            {
                return false;
            }
        }
        return true;
    }
}

