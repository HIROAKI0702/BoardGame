using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRandomDice : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    public GameObject DiceButton;

    public Sprite newSprite;

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
    //前回生成されたオブジェクトを保存するリスト
    private List<GameObject> LastTimeDice = new List<GameObject>();

    private Image image;

    Button btn;

    int rerollCount = 0;

    void Start()
    {
        btn = GetComponent<Button>();
        image = GetComponent<Image>();
    }

    public void OnClick()
    {
        SpawnObjects();
        //一度しかボタンを押せないようにする
        btn.interactable = false;
    }

    void SpawnObjects()
    {
        if (Turnprogram.MyTurnFlag == true)
        {
            RemoveDice();
            rerollCount++;

            //生成するオブジェクトの数を決定
            int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

            //生成されたオブジェクトの数が指定された数に達するまでループ
            for (int i = 0; i < objectsToSpawn; i++)
            {
                //指定された位置を取得
                Vector3 newPosition = spawnPositions[i];

                //リストに新しい位置を保存
                spawnedPositions.Add(newPosition);

                //ランダムなプレハブを選択して生成
                GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
                GameObject Dice = Instantiate(prefabSpawn, newPosition, Quaternion.identity);

                LastTimeDice.Add(Dice);

                

                StartCoroutine(ReRoll());
            }
        }
    }

    void RemoveDice()
    {
        foreach(GameObject obj in LastTimeDice)
        {
            Destroy(obj);
        }
        LastTimeDice.Clear();
    }

    IEnumerator ReRoll()
    {
        yield return new WaitForSeconds(2f);

        image.sprite = newSprite;
        btn.interactable = true;
        Debug.Log(rerollCount);

        if (rerollCount == 3)
        {
            btn.interactable = false;
            Debug.Log(rerollCount);
        }
      
        yield break;
    }
}

