using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameOver : MonoBehaviour
{
    public Manager datareceive;
    public Text text;
    public Score score;
    private bool updateEnabled = false;
    void Start(){
        this.gameObject.SetActive(false);
    }
    void Update(){
        if(updateEnabled){
            if(datareceive.getJump()){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void showGameOver(){
        score.disableScore();
        Time.timeScale = 0;
        this.gameObject.SetActive(true);
        this.updateEnabled = true;
        text.text = "Your score is : "+score.getScore()+"\nHandful to play again";
    }
}


