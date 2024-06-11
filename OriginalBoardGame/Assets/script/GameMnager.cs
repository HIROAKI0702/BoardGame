using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMnager : MonoBehaviour
{
    public string sceneNameTitle;
    public string sceneNameAS;
    public string sceneNameG;
    public string scenenameC;
    public string scenenameO;

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
        if(Input.GetButton("Fire1"))
        {
            dispatch(GameState.TITLE);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
