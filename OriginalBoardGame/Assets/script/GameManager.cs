using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string sceneNameTitle;
    public string sceneNameAS;
    public string sceneNameG;
    public string scenenameC;
    public string scenenameO;

    //自分のターンか敵のターンかを判断
    public bool MyTurnFlag = false;
    public bool ReturnPushFlag = false;
    public bool playerAttackTurnFlag = false;
    public bool enemyAttackTurnFlag = false;

    public PlayerRandomDice playerrandomdice;
    public EnemyRandomDice enemyrandomdice;
    public ChoiceDice choicedice;

    public Vector3 pos = new Vector3(-6f, 0.3f, 0.0f);

    public Button btn;

    public enum GameState
    {
        TITLE,
        AITEMSELECT,
        GAME,
        OPTION,
        CLEAR,
        GAMEOVER
    }

    public GameState currentState = GameState.TITLE;

    public static string gState = "title";

    // Start is called before the first frame update
    void Start()
    {
        MyTurnFlag = true;
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            dispatch(GameState.TITLE);
        }

        if (choicedice.count == 5)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //サイコロを５つ選んだら敵のターンになる
                MyTurnFlag = false;
                choicedice.pushEnter.text = "";

                ReturnPushFlag = true;
                StartCoroutine(TurnDeley());             
            }
        }
    }

    public void dispatch(GameState state)
    {
        currentState = state;
        switch(state)
        {
            case GameState.TITLE:
                GameTitle();
                break;
            case GameState.AITEMSELECT:
                GameHome();
                break;
            case GameState.GAME:
                GamePlayng();
                break;
            case GameState.OPTION:
                GamePose();
                break;
            case GameState.CLEAR:
                GameClear();
                break;
            case GameState.GAMEOVER:
                GameOver();
                break;
        }
    }

    void GameTitle()
    {
        Debug.Log("title");        
    }

    void GameHome()
    {
        gState = "home";
        Debug.Log("home");
    }

    void GamePlayng()
    {
        gState = "playng";
        Debug.Log("playng");

        if (MyTurnFlag && !btn.interactable)
        {
            btn.interactable = true;
            Debug.Log(MyTurnFlag);
        }
    }

    void GamePose()
    {
        gState = "pose";
        Debug.Log("pose");
    }
    
    void GameClear()
    {
        gState = "clesr";
        Debug.Log("clear");
    }

    void GameOver()
    {
        gState = "end";
        Debug.Log("gameover");
    }

    IEnumerator TurnDeley()
    {
        yield return new WaitForSeconds(5f);

        choicedice.count = 0;
        Debug.Log(choicedice.count);
        enemyrandomdice.EnemyTurn();

        yield break;
    }
}
