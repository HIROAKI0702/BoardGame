using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChangeScript : MonoBehaviour
{
    public PlayerAttackPhaseProgram PAPP;
    public EnemyAttackPhaseProgram EAPP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PAPP.playerDiceFlagCount[5] == true && EAPP.enemyDiceFlagCount[5] == true)
        {
            StartCoroutine(Deley());
            PAPP.playerDiceFlagCount[PAPP.count] = false;
            EAPP.enemyDiceFlagCount[EAPP.count] = false;
        }
    }

    IEnumerator Deley()
    {
        yield return new WaitForSeconds(2f);

        StatusChange();

        yield break;
    }

    public void StatusChange()
    {

    }
}
