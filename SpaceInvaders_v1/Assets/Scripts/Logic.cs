using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public int movespeed;
    private Vector3 Direction;
    private GameObject[] shooters;
    private GameObject[] reds;
    private GameObject[] blues;

    public bool flag = true;
    public float period = 0.0f;
    float interval = 0f;
    // Use this for initialization
    void Start()
    {
        movespeed = 25;   // i increased this to make it easier to see
    }

    // Update is called once per frame
    void Update()
    {
       // Move enemies
            if (period >= 1f)
            {
                //Do Stuff
                Debug.Log("Moving" + flag);
                if (flag)
                {
                    PerformLeftMove();
                } 
                else
                {
                    PerformRightMove();
                }
                
                interval += 1;

                if (interval % 5 == 0)
                {
                    flag = !flag;
                    Debug.Log(flag);  
                }

                period = 0;
            }
        period += UnityEngine.Time.deltaTime;
    }

    void PerformLeftMove()                                                                         
    {
        Direction = Vector3.right;

        shooters = GameObject.FindGameObjectsWithTag("Shooter");
        foreach (GameObject s in shooters)
        {
           s.transform.Translate(Direction * movespeed * Time.deltaTime);
        }

        reds = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject r in reds)
        {
            r.transform.Translate(Direction * movespeed * Time.deltaTime);
        }

        blues = GameObject.FindGameObjectsWithTag("Enemy2");
        foreach (GameObject b in blues)
        {
            b.transform.Translate(Direction * movespeed * Time.deltaTime);
        }

    }

    void PerformRightMove()
    {     
        Direction = Vector3.left;

        shooters = GameObject.FindGameObjectsWithTag("Shooter");
        foreach (GameObject s in shooters)
        {
           s.transform.Translate(Direction * movespeed * Time.deltaTime);
        }

        reds = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject r in reds)
        {
            r.transform.Translate(Direction * movespeed * Time.deltaTime);
        }

        blues = GameObject.FindGameObjectsWithTag("Enemy2");
        foreach (GameObject b in blues)
        {
            b.transform.Translate(Direction * movespeed * Time.deltaTime);
        }
    }
}
