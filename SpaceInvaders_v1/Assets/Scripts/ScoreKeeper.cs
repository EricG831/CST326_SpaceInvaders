using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void refresh(int score)
    {
        Score += score;
        Debug.Log(Score);

        if(Score >= 100)
        {
            scoreText.text = "SCORE\n0" + Score;
        } else
        {
            scoreText.text = "SCORE\n00" + Score;
        }
        //scoreText.text = 
    }
}
