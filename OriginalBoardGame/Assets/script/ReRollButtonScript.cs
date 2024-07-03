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
        btn.interactable = false;
        prd.SpawnObjects();

        if (prd.reRollFlag == true)
        {
            btn.interactable = true;

            if (prd.rerollCount == 5)
            {
                btn.interactable = false;
            }
        }
    }
}
