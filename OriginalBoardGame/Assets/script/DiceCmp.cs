using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCmp : MonoBehaviour
{
    public ChoiceDice choicedice;
    public EnemyRandomDice ERD;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 5; i++)
        {
            if(choicedice.selectObject[i].tag == "NormalSword" || 
               choicedice.selectObject[i].tag == "APSword" && 
               ERD.selectObject[i].tag == "NormalArmer" || 
               ERD.selectObject[i].tag == "APArmer")
            {

            }
        }
    }
}
