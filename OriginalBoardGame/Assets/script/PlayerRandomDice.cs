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

    //��������I�u�W�F�N�g�̐�
    public int spawnObject = 5;
    //�I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistance = 1.0f;

    //�����[�����t���O
    public bool reRollFlag = false;

    //��������̃v���n�u��ۑ����郊�X�g
    public List<GameObject> saikoroObject;
    //��������ʒu�̃��X�g
    public List<Vector3> spawnPositions;
    //�����ς݂̃I�u�W�F�N�g�̈ʒu��ۑ����郊�X�g
    private List<Vector3> spawnedPositions = new List<Vector3>();
    //�O�񐶐����ꂽ�I�u�W�F�N�g��ۑ����郊�X�g
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
    }

    public void OnClick()
    {
        SpawnObjects();
        //��x�����{�^���������Ȃ��悤�ɂ���
        btn.interactable = false;      
    }

    public void SpawnObjects()
    {
        //��������I�u�W�F�N�g�̐�������
        //int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        float randomDice = Random.Range(0f, 1f);

        RemoveDice();

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        for (int i = 0; i < spawnObject - choicedice.count; i++)
        {
            //�w�肳�ꂽ�ʒu���擾
            Vector3 newPosition = spawnPositions[i];

            //���X�g�ɐV�����ʒu��ۑ�
            spawnedPositions.Add(newPosition);

            ////�����_���ȃv���n�u��I�����Đ���
            //prefabSpawn = saikoroObject[Random.Range(0, 12)];
            ////GameObject Dice = Instantiate(saikoroObject[Random.Range(0, saikoroObject.Count)], newPosition, Quaternion.identity);
            //GameObject Dice = Instantiate(prefabSpawn, newPosition, Quaternion.identity);

            if(randomDice < 0.7f)
            {
                Dice = Instantiate(saikoroObject[Random.Range(0, 5)], newPosition, Quaternion.identity);
            }
            else
            {
                Dice = Instantiate(saikoroObject[Random.Range(6, 11)], newPosition, Quaternion.identity);
            }

            LastTimeDice.Add(Dice);

            rerollCount++;
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
}

