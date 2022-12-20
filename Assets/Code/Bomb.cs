using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float speed = 1.0f;
    public Score score;
    void Start()
    {
        transform.position = new Vector3(13, Random.Range(-4, 4), 0);
    }
    void Update()
    {
        if (transform.position.x >= -13){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            score.addScore();
            this.speed++;
            transform.position = new Vector3(13, Random.Range(-3, 3), 0);
        }
    }
}
