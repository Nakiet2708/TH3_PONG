using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_pong : MonoBehaviour
{
    public Text Scoreboard;
    private int Bat1_Score = 0;
    private int Bat2_Score = 0;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 35f)
        {
            Bat1_Score++;
        }
        if (ball.transform.position.x <= -35f)
        {
            Bat2_Score++;
        }
        Scoreboard.text = Bat1_Score.ToString() + " - " + Bat2_Score.ToString();
        print (Bat1_Score + " , " +  Bat2_Score);
    }
}
