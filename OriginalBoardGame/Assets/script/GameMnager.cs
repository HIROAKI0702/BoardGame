using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMnager : MonoBehaviour
{
    public enum GameState
    {
        TITLE,
        AITEMSELECT,
        GAME,
        OPTION,
        CLEAR,
        END
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
            case GameState.END:
                GameOver();
                break;
        }
    }

    void GameTitle()
    {

    }

    void GameHome()
    {
        gState = "home";
    }

    void GamePlayng()
    {
        gState = "playng";
    }

    void GamePose()
    {
        gState = "pose";
    }
    
    void GameClear()
    {
        gState = "clesr";
    }

    void GameOver()
    {
        gState = "end";
    }
}
