using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public Logic logic;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.tag == "Shooter")
        {
            Debug.Log("Ouch, hit shooter!");
            scoreKeeper.refresh(30);
        }

        if (this.tag == "Enemy")
        {
            Debug.Log("Ouch, hit Enemy!");
            scoreKeeper.refresh(20);
        }

        if (this.tag == "Enemy2")
        {
            Debug.Log("Ouch, hit Enemy2!");
            scoreKeeper.refresh(10);
        }

    }

}
