using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    public Text finalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finalScoreText.text = "You avoided the NBA Finals Trophy for " + score.text
            + " seconds!";
        score.enabled = false;
    }
}
