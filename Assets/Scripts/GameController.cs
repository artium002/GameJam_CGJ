using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text scoretext;
    public Text TimeText;
    private bool GameEnded = false;


    public float counter = 100;
    private float PCounter;

    private int BaseScore = 0;
    public int score;



    // Start is called before the first frame update
    void Start()
    {
        PCounter = counter;

        score = BaseScore;
        UpdateScore();
    }




    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown (KeyCode.Space) && !GameEnded)
        {
            //add score and update the text
            score += 100;
            UpdateScore();

            // add time to countdown
            PCounter += 50;
        }


        if (Input.GetKeyDown(KeyCode.H) && !GameEnded)
        {
            //decrease score (maybe reduce countdown)
            score -= 50;
            UpdateScore();
        }
    }

    void FixedUpdate() 
    {
        if (PCounter<= 0) 
            {
                EndGame();
            }
        if (!GameEnded)
        {
        PCounter -= Time.deltaTime;
        TimeText.text = (Mathf.Round(PCounter)).ToString();
        }
    }

    // update score text, makes sure there are no negative score.
    private void UpdateScore()
    {
        scoretext.text = Mathf.Round(score).ToString(); 
        if (score <= 0)
            {
                scoretext.text = "0"; 
            }
    }

    private void EndGame()
    {
            Debug.Log("GameEnded");
            GameEnded = true;
    }

    public void AddScore(int AScore, int ATime)
    {
        score += AScore;
        PCounter += ATime;
        UpdateScore();
    }

}
