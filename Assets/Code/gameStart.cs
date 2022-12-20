using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public Manager datareceive;
    public Character character;
    public Score score;
    void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if (datareceive.getJump())
        {
            character.characterStart();
            score.startScore();
            Time.timeScale = 1;
            this.gameObject.SetActive(false);
        }
    }
}
