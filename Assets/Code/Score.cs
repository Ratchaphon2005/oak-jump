using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    private int score = 0;
    void Start()
    {
        this.gameObject.SetActive(false);
    }
    public void startScore(){
        this.gameObject.SetActive(true);
        text.text = "Score: " + score;
    }
    public void addScore(){
        this.score++;
        text.text = "Score: " + score;
    }
    public void disableScore(){
        this.gameObject.SetActive(false);
    }
    public int getScore(){
        return this.score;
    }
}
