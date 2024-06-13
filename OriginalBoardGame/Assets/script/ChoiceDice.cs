using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceDice : MonoBehaviour
{
    GameObject NormalSword;
    GameObject NormalShield;
    GameObject NormalBow;
    GameObject NormalArmer;
    GameObject NormalSteal;
    GameObject NormalCounter;
    GameObject APSword;
    GameObject APShield;
    GameObject APBow;
    GameObject APArmer;
    GameObject APSteal;
    GameObject APCounter;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            DiceClick();
        }
    }

    void DiceClick()
    {
        NormalSword = null;
        NormalShield = null;
        NormalBow = null;
        NormalArmer = null;
        NormalSteal = null;
        NormalCounter = null;
        APSword = null;
        APShield = null;
        APBow = null;
        APArmer = null;
        APSteal = null;
        APCounter = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (hit2d)
        {
            NormalSword = hit2d.transform.gameObject;
            NormalShield = hit2d.transform.gameObject;
            NormalBow = hit2d.transform.gameObject;
            NormalArmer = hit2d.transform.gameObject;
            NormalSteal = hit2d.transform.gameObject;
            NormalCounter = hit2d.transform.gameObject;
            APSword = hit2d.transform.gameObject;
            APShield = hit2d.transform.gameObject;
            APBow = hit2d.transform.gameObject;
            APArmer = hit2d.transform.gameObject;
            APSteal = hit2d.transform.gameObject;
            APCounter = hit2d.transform.gameObject;
        }

        Debug.Log(NormalSword + "Œ•");
    }
}
