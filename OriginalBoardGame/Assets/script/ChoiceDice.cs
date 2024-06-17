using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceDice : MonoBehaviour
{
    public GameObject NormalSword;
    public GameObject NormalShield;
    public GameObject NormalBow;
    public GameObject NormalArmer;
    public GameObject NormalSteal;
    public GameObject NormalCounter;
    public GameObject APSword;
    public GameObject APShield;
    public GameObject APBow;
    public GameObject APArmer;
    public GameObject APSteal;
    public GameObject APCounter;

    Vector3 pos;

    Vector3 pos1 = new Vector3(-3.359198f, 0.2371934f, 10);
    Vector3 pos2 = new Vector3(-1.879198f, 0.2371934f, 10);
    Vector3 pos3 = new Vector3(-0.379198f, 0.2421934f, 10);
    Vector3 pos4 = new Vector3( 1.115802f, 0.2471934f, 10);
    Vector3 pos5 = new Vector3( 2.615802f, 0.2381934f, 10);

    int count = 1;

    bool ClickFlag = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            DiceClick();
        }
    }

    void DiceClick()
    {  
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (count == 1)
            pos = pos1;
        if (count == 2)
            pos = pos2;
        if (count == 3)
            pos = pos3;
        if (count == 4)
            pos = pos4;
        if (count == 5)
            pos = pos5;

        if (hit2d)
        {
            GameObject NormalSword = hit2d.collider.gameObject;
            if(NormalSword.CompareTag("NormalSword"))
            {
                Debug.Log("åï");
                Instantiate(NormalSword, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if(ClickFlag == true)
                {
                    NormalSword.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject NormalShield = hit2d.collider.gameObject;
            if (NormalShield.CompareTag("NormalShield"))
            {
                Debug.Log("èÇ");
                Instantiate(NormalShield, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    NormalShield.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject NormalBow = hit2d.collider.gameObject;
            if (NormalBow.CompareTag("NormalBow"))
            {
                Debug.Log("ã|");
                Instantiate(NormalBow, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    NormalBow.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject NormalArmer = hit2d.collider.gameObject;
            if (NormalArmer.CompareTag("NormalArmer"))
            {
                Debug.Log("äZ");
                Instantiate(NormalArmer, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    NormalArmer.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject NormalSteal = hit2d.collider.gameObject;
            if (NormalSteal.CompareTag("NormalSteal"))
            {
                Debug.Log("ìêÇﬁ");
                Instantiate(NormalSteal, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    NormalSteal.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject NormalCounter = hit2d.collider.gameObject;
            if (NormalCounter.CompareTag("NormalCounter"))
            {
                Debug.Log("ÉJÉEÉìÉ^Å[");
                Instantiate(NormalCounter, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    NormalCounter.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APSword = hit2d.collider.gameObject;
            if (APSword.CompareTag("APSword"))
            {
                Debug.Log("APåï");
                Instantiate(APSword, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APSword.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APShield = hit2d.collider.gameObject;
            if (APShield.CompareTag("APShield"))
            {
                Debug.Log("APèÇ");
                Instantiate(APShield, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APShield.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APBow = hit2d.collider.gameObject;
            if (APBow.CompareTag("APBow"))
            {
                Debug.Log("APã|");
                Instantiate(APBow, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APBow.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APArmer = hit2d.collider.gameObject;
            if (APArmer.CompareTag("APArmer"))
            {
                Debug.Log("APäZ");
                Instantiate(APArmer, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APArmer.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APSteal = hit2d.collider.gameObject;
            if (APSteal.CompareTag("APSteal"))
            {
                Debug.Log("APìêÇﬁ");
                Instantiate(APSteal, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APSteal.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
            GameObject APCounter = hit2d.collider.gameObject;
            if (APCounter.CompareTag("APCounter"))
            {
                Debug.Log("APÉJÉEÉìÉ^Å[");
                Instantiate(APCounter, pos, Quaternion.identity);
                count++;
                ClickFlag = true;
                if (ClickFlag == true)
                {
                    APCounter.GetComponent<BoxCollider2D>().enabled = false;
                }
            }
        }      
    }
}
