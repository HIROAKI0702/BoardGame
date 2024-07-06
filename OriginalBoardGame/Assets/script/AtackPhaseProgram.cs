using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackPhaseProgram : MonoBehaviour
{
    public GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void NormalSwordFunction(GameObject dice)
    {
        if(gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalSwordFunction");
        }
    }

    public void NormalShieldFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalShieldFunction");
        }
    }

    public void NormalBowFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalBowFunction");
        }
    }

    public void NormalArmerFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalArmerFunction");
        }
    }

    public void NormalStealFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalStealFunction");
        }
    }

    public void NormalCounterFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalCounterFunction");
        }
    }

    public void APSwordFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APSwordFunction");
        }
    }

    public void APShieldFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APShieldFunction");
        }
    }

    public void APBowFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APBowFunction");
        }
    }

    public void APArmerFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APArmerFunction");
        }
    }

    public void APStealFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APStealFunction");
        }
    }

    public void APCounterFunction(GameObject dice)
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APCounterFunction");
        }
    }
}
