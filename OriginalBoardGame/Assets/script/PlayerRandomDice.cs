using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomDice : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    //��������̃v���n�u��ۑ����郊�X�g
    public List<GameObject> saikoroObject;
    //��������ʒu�̃��X�g
    public List<Vector3> spawnPositions;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //��������I�u�W�F�N�g�̐�
    public int spawnObject = 5;

    //�I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistance = 1.0f;

    //�����ς݂̃I�u�W�F�N�g�̈ʒu��ۑ����郊�X�g
    private List<Vector3> spawnedPositions = new List<Vector3>();

    void Start()
    {
    }

    public void OnClick()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //��������I�u�W�F�N�g�̐�������
        int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

        ////��������ʒu�̃��X�g���V���b�t�����ă����_���ɑI������
        //List<Vector3> shuffledPositions = new List<Vector3>(spawnPositions);
        //Shuffle(shuffledPositions);

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        for (int i = 0; i < objectsToSpawn; i++)
        {
            //�w�肳�ꂽ�ʒu���擾
            Vector3 newPosition = spawnPositions[i];

            //���X�g�ɐV�����ʒu��ۑ�
            spawnedPositions.Add(newPosition);

            //�����_���ȃv���n�u��I�����Đ���
            GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            Instantiate(prefabSpawn, newPosition, Quaternion.identity);
        }
    }

    //// ���X�g���V���b�t�����郁�\�b�h
    //void Shuffle<T>(List<T> list)
    //{
    //    int n = list.Count;
    //    for (int i = 0; i < n; i++)
    //    {
    //        int r = Random.Range(i, n);
    //        T tmp = list[i];
    //        list[i] = list[r];
    //        list[r] = tmp;
    //    }
    //}
}
