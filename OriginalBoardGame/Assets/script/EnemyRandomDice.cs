using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomDice : MonoBehaviour
{
    public GameManager gamemanager;
    public EnemyChoiceDice ecd;

    public GameObject Stage1;
    public GameObject Stage2;

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
    //�_�C�X�̈ړ���̈ʒu�̃��X�g
    public List<Vector3> movePosition;
    public List<Vector3> setPosition;


    private Vector3 NewScale = new Vector3(0.5f, 0.5f, 0.5f);
    private Vector3 SetScale = new Vector3(0.3f, 0.3f, 0.3f);


    void Start()
    {
       
    }

    private void Update()
    {
    }

    public void EnemyTurn()
    {
        RemoveDice();

        //��������I�u�W�F�N�g�̐�������
        int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        for (int i = 0; i < objectsToSpawn; i++)
        {
            //�w�肳�ꂽ�ʒu���擾
            Vector3 newPosition = spawnPositions[i];

            //���X�g�ɐV�����ʒu��ۑ�
            spawnedPositions.Add(newPosition);

            //�����_���ȃv���n�u��I�����Đ���
            //GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            GameObject Dice = Instantiate(saikoroObject[Random.Range(0, saikoroObject.Count)], newPosition, Quaternion.identity);
            LastTimeDice.Add(Dice);
        }
        StartCoroutine(MoveDice());
        //StartCoroutine(ecd.Enemy());
    }

    void RemoveDice()
    {
        foreach (GameObject obj in LastTimeDice)
        {
            Destroy(obj);
        }
        LastTimeDice.Clear();
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
                    LastTimeDice[i].transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                    LastTimeDice[i].transform.localScale = NewScale;
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
        Debug.Log(gamemanager.MyTurnFlag);
    }
}

