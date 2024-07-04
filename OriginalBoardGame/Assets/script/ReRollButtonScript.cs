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
        if (prd.reRollFlag == true)
        {
            prd.SpawnObjects();
            btn.interactable = true;

            if (prd.rerollCount == 5)
            {
                Debug.Log(prd.rerollCount);
                btn.interactable = false;
            }
        }
    }
}
