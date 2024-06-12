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

    //��������I�u�W�F�N�g�̐�
    public int spawnObject = 5;

    //�I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistanceBetweenObjects = 1.0f;

    //�����ς݂̃I�u�W�F�N�g�̈ʒu��ۑ����郊�X�g
    private List<Vector3> spawnedPositions = new List<Vector3>();

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //�������ꂽ�I�u�W�F�N�g�̐���ǐՂ���ϐ�
        int objectsSpawned = 0;

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        while (objectsSpawned < spawnObject) 
        {
            Vector3 newPosition = GetRandomPosition(minPosition, maxPosition);
            bool validPosition = IsPositionValid(newPosition, minDistanceBetweenObjects);

            if (validPosition)
            {
                spawnedPositions.Add(newPosition);

                //�����_���ȃv���n�u��I�����Đ���
                GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
                Instantiate(prefabSpawn, newPosition, Quaternion.identity);

                objectsSpawned++; //�������ꂽ�I�u�W�F�N�g�̐��𑝂₷
            }
        }
    }

    //�͈͓��̃����_���Ȉʒu���v�Z
    Vector3 GetRandomPosition(Vector3 min, Vector3 max)
    {
        return new Vector3(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y),
            Random.Range(min.z, max.z)
        );
    }

    // �������ꂽ�ʒu�����̃I�u�W�F�N�g�̈ʒu�Əd�Ȃ�Ȃ������m�F
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

