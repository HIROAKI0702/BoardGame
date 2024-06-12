using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSaikoro : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    public GameObject NSword;
    //public GameObject APSword;
    //public GameObject Nshield;
    //public GameObject APshield;
    //public GameObject NBow;
    //public GameObject APBow;
    //public GameObject NArmer;
    //public GameObject APArmer;
    //public GameObject NCounter;
    //public GameObject APCounter;
    //public GameObject NSteal;
    //public GameObject APSteal;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    // 生成するオブジェクトの数
    public int numberOfObjects = 10;

    // オブジェクト間の最小距離
    public float minDistanceBetweenObjects = 1.0f;

    // 生成済みの位置を保持するリスト
    private List<Vector3> spawnedPositions = new List<Vector3>();

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 newPosition;
            bool validPosition = false;

            do
            {
                newPosition = GetRandomPositionInRectangle(minPosition, maxPosition);
                validPosition = IsPositionValid(newPosition, minDistanceBetweenObjects);
            } while (!validPosition);

            spawnedPositions.Add(newPosition);
            Instantiate(NSword, newPosition, Quaternion.identity);
        }
    }

    // 矩形範囲内のランダムな位置を計算するメソッド
    Vector3 GetRandomPositionInRectangle(Vector3 min, Vector3 max)
    {
        return new Vector3(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y),
            Random.Range(min.z, max.z)
        );
    }

    // 生成された位置が他のオブジェクトの位置と重ならないかを確認するメソッド
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

