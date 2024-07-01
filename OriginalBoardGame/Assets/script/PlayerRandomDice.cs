using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRandomDice : MonoBehaviour
{
    public GameManager gamemanagers;
    public ChoiceDice choicedice;

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject DiceButton;
    GameObject prefabSpawn;
    GameObject Dice;

    public Sprite newSprite;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //生成するオブジェクトの数
    public int spawnObject = 5;
    //オブジェクト間の最小距離
    public float minDistance = 1.0f;

    //さいころのプレハブを保存するリスト
    public List<GameObject> saikoroObject;
    //生成する位置のリスト
    public List<Vector3> spawnPositions;
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

    private void Update()
    {
    }

    public void OnClick()
    {
        SpawnObjects();
        //一度しかボタンを押せないようにする
        btn.interactable = false;      
    }

    public void SpawnObjects()
    {
        RemoveDice();

        //生成するオブジェクトの数を決定
        int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        //生成されたオブジェクトの数が指定された数に達するまでループ
        for (int i = 0; i < spawnObject - choicedice.count; i++)
        {
            //指定された位置を取得
            Vector3 newPosition = spawnPositions[i];

            //リストに新しい位置を保存
            spawnedPositions.Add(newPosition);

            //ランダムなプレハブを選択して生成
            prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            Instantiate(prefabSpawn, newPosition, Quaternion.identity);
            LastTimeDice.Add(Dice);

            StartCoroutine(ReRoll());
        }
        rerollCount++;
        Debug.Log(choicedice.count);
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

        if (rerollCount == 5)
        {
            btn.interactable = false;
        }
      
        yield break;
    }
}

