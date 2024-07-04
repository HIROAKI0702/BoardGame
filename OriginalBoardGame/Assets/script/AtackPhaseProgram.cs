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

    public void NormalSwordFunction()
    {
        if(gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalSwordFunction");
        }
    }

    public void NormalShieldFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalShieldFunction");
        }
    }

    public void NormalBowFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalBowFunction");
        }
    }

    public void NormalArmerFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalArmerFunction");
        }
    }

    public void NormalStealFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalStealFunction");
        }
    }

    public void NormalCounterFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("NormalCounterFunction");
        }
    }

    public void APSwordFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APSwordFunction");
        }
    }

    public void APShieldFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APShieldFunction");
        }
    }

    public void APBowFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APBowFunction");
        }
    }

    public void APArmerFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APArmerFunction");
        }
    }

    public void APStealFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APStealFunction");
        }
    }

    public void APCounterFunction()
    {
        if (gamemanager.atackTurnFlag == true)
        {
            Debug.Log("APCounterFunction");
        }
    }
}
