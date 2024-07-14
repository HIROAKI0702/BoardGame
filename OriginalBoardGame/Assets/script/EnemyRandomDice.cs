using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomDice : MonoBehaviour
{
    public GameManager gamemanager;
    public EnemyAttackPhaseProgram EAPP;
    public FunctionCallScript FCS;

    public GameObject Stage1;
    public GameObject Stage2;

    public Vector3 minPosition;
    public Vector3 maxPosition;

    //��������I�u�W�F�N�g�̐�
    public int spawnObject = 5;
    public int count = 0;

    //�I�u�W�F�N�g�Ԃ̍ŏ�����
    public float minDistance = 1.0f;

    //�_�C�X�ɑΉ������֐����ĂԂ��߂̃t���O
    public bool playercallDiceFlag = false;
    public bool enemycallDiceFlag = false;

    //��������̃v���n�u��ۑ����郊�X�g
    public List<GameObject> saikoroObject;
    //��������ʒu�̃��X�g
    public List<Vector3> spawnPositions;
    //�����ς݂̃I�u�W�F�N�g�̈ʒu��ۑ����郊�X�g
    private List<Vector3> spawnedPositions = new List<Vector3>();
    //�O�񐶐����ꂽ�I�u�W�F�N�g��ۑ����郊�X�g
    private List<GameObject> LastTimeDice = new List<GameObject>();
    //�_�C�X�ɑΉ�����֐���ێ����郊�X�g
    private List<System.Action> diceFunction = new List<System.Action>();
    //�_�C�X�̊֐����ĂԂ��߂̃^�O�̃��X�g
    public List<string> selectTag = new List<string>();
    //�_�C�X�̊֐����ĂԂ��߂̃_�C�X�̃��X�g
    public List<GameObject> selectObject = new List<GameObject>();

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
        if (enemycallDiceFlag == true)
        {
            EnemyDiceCallTag();
            enemycallDiceFlag = false;
        }
    }

    public void EnemyTurn()
    {
        if (gamemanager.MyTurnFlag == false)
        {
            RemoveDice();

            //��������I�u�W�F�N�g�̐�������
            //int objectsToSpawn = Mathf.Min(spawnPositions.Count, saikoroObject.Count);

            //�������ꂽ�I�u�W�F�N�g�̐����w�肳�ꂽ���ɒB����܂Ń��[�v
            for (int i = 0; i < spawnObject; i++)
            {
                //�w�肳�ꂽ�ʒu���擾
                Vector3 newPosition = spawnPositions[i];

                //���X�g�ɐV�����ʒu��ۑ�
                spawnedPositions.Add(newPosition);
                
                count++;

                //�����_���ȃv���n�u��I�����Đ���
                //GameObject prefabSpawn = saikoroObject[Random.Range(0, saikoroObject.Count)];
                GameObject Dice = Instantiate(saikoroObject[GetRandomDice()], newPosition, Quaternion.identity);

                string tag = Dice.tag;

                LastTimeDice.Add(Dice);
                //�_�C�X�̊֐����ĂԂ��߂Ƀ^�O�ƃ_�C�X��������
                selectTag.Add(tag);
                selectObject.Add(Dice);

                //�G��Ȃ��悤�ɃR���C�_�[�������Ă���
                Dice.GetComponent<BoxCollider2D>().enabled = false;
            }
            StartCoroutine(MoveDice());          
        }
    }

    void RemoveDice()
    {
        //�����[���ōĐ�������ۂɁA�O�̃_�C�X������
        foreach (GameObject obj in LastTimeDice)
        {
            Destroy(obj);
        }
        LastTimeDice.Clear();
    }

    int GetRandomDice()
    {
        int[] weight = new int[20];
        int index = 0;

        //0�`5�͈̔͂őI�΂��
        for (int i = 0; i < 6; i++)
        {
            weight[index++] = i;
            weight[index++] = i;//2�{�ɂ���
        }
        for (int i = 6; i < saikoroObject.Count; i++)
        {
            weight[index++] = i;
        }

        return weight[Random.Range(0, weight.Length)];

    }

    void EnemyDiceCallTag()
    {
        //�^�O�̌����i5�j
        for (int i = 0; i < selectTag.Count; i++)
        {
            EAPP.CompareDice();
        }
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
                    //���`�⊮�ɂ��Q�]���̋��������炩�Ɉړ�������@�n�_�@�@�@�@�@ �I�_�@�@�@�@�@�@�⊮�̊���
                    LastTimeDice[i].transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                    LastTimeDice[i].transform.localScale = NewScale;//�T�C�Y�ύX
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
        playercallDiceFlag = true;
        enemycallDiceFlag = true;
    }
}

