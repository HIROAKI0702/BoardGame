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

    //��������I�u�W�F�N�g�̐�
    public int spawnObject = 5;
    //�I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistance = 1.0f;

    //��������̃v���n�u��ۑ����郊�X�g
    public List<GameObject> saikoroObject;
    //��������ʒu�̃��X�g
    public List<Vector3> spawnPositions;
    //�����ς݂̃I�u�W�F�N�g�̈ʒu��ۑ����郊�X�g
    private List<Vector3> spawnedPositions = new List<Vector3>();
    //�O�񐶐����ꂽ�I�u�W�F�N�g��ۑ����郊�X�g
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
        //��x�����{�^���������Ȃ��悤�ɂ���
        btn.interactable = false;      
    }

    public void SpawnObjects()
    {
        RemoveDice();

        //��������I�u�W�F�N�g�̐�������
        int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        for (int i = 0; i < spawnObject - choicedice.count; i++)
        {
            //�w�肳�ꂽ�ʒu���擾
            Vector3 newPosition = spawnPositions[i];

            //���X�g�ɐV�����ʒu��ۑ�
            spawnedPositions.Add(newPosition);

            //�����_���ȃv���n�u��I�����Đ���
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

