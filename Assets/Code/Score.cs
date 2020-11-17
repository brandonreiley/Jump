using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int currentScore;
    public int scoreIncr;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        scoreIncr = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += scoreIncr;
            scoreText.text = currentScore + "";
        }
    }
}
