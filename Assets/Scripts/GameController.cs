using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text scoretext;

    private bool GameEnded = false;


    private int BaseScore = 0;
    public int score;



    // Start is called before the first frame update
    void Start()
    {
        score = BaseScore;
        UpdateScore();
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space) && !GameEnded)
        {
            score += 100;
            UpdateScore();
        }
        if (Input.GetKeyDown(KeyCode.H) && !GameEnded)
        {
            score -= 50;
            UpdateScore();
        }


        if (score < 0 && !GameEnded)
        {
            Debug.Log("GameEnded");
            GameEnded = true;
        }
        
    }

    private void UpdateScore()
    {
        scoretext.text = score.ToString(); if (score <= 0)
        

        {
            scoretext.text = "0"; 
        }
    }
}
