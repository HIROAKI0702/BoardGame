using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRandomDice : MonoBehaviour
{
    public GameObject Stage1;
    public GameObject Stage2;

    //��������̃v���n�u��ۑ����郊�X�g
    public List<GameObject> saikoroObject;
    //����������X�|�[��������|�W�V������ۑ����郊�X�g
    public List<Vector3> DiceSpawnPosition;

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
        //SpawnObjects();
    }

    public void OnClick()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        //�d�Ȃ������ɂ��炷�������K�v

        //�������ꂽ�I�u�W�F�N�g�̐���ǐՂ���ϐ�
        int objectSpawned = 0;

        //int objectsToSpawn = Mathf.Min(spawnedPositions.Count, saikoroObject.Count); // ��������I�u�W�F�N�g�̐�������

        //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
        while (objectSpawned < spawnObject)
        {
            //Vector�^��newPosition�Ƀ����_���̃|�W�V�������擾����֐����Ă�
            Vector3 newPosition = GetRandomPosition(minPosition, maxPosition);

            spawnedPositions.Add(newPosition);

           
            //�����_���ȃv���n�u��I�����Đ���
            GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
            Instantiate(prefabSpawn, newPosition, Quaternion.identity);

            objectSpawned++; //�������ꂽ�I�u�W�F�N�g�̐��𑝂₷)
                    
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
}

