using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float currentScore;
    public float scoreIncr;
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
        if (PlayerCollision.gameIsPaused == false)
        {
            Time.timeScale += .001f;
            currentScore += scoreIncr * Time.unscaledDeltaTime;
            scoreText.text = (int)currentScore + "";
        }
    }
}
