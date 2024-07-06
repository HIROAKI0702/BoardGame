using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ReRollButtonScript : MonoBehaviour
{
    public PlayerRandomDice prd;
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        btn.interactable = true;
        ReRoll();
    }

    void ReRoll()
    {
        if(prd.rerollCount < 3)
        {
            prd.rerollCount++;
            prd.SpawnObjects();
        }
        else
        {
            btn.interactable = false;
        }
    }
}
