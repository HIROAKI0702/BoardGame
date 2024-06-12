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

    // ��������I�u�W�F�N�g�̐�
    public int numberOfObjects = 10;

    // �I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistanceBetweenObjects = 1.0f;

    // �����ς݂̈ʒu��ێ����郊�X�g
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

    // ��`�͈͓��̃����_���Ȉʒu���v�Z���郁�\�b�h
    Vector3 GetRandomPositionInRectangle(Vector3 min, Vector3 max)
    {
        return new Vector3(
            Random.Range(min.x, max.x),
            Random.Range(min.y, max.y),
            Random.Range(min.z, max.z)
        );
    }

    // �������ꂽ�ʒu�����̃I�u�W�F�N�g�̈ʒu�Əd�Ȃ�Ȃ������m�F���郁�\�b�h
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

