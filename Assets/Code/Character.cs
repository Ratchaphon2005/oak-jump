using UnityEngine;

public class Character : MonoBehaviour
{   
    private Rigidbody2D rb;
    public float jumpForce = 10f;
    public Manager datareceive;
    public gameOver gameover;
    public playAudio playJumpSound;
    public playAudio playDeathSound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (datareceive.getJump())
        {
            rb.velocity = Vector2.up * jumpForce;
            datareceive.setJump(false);
            playJumpSound.playSound();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.SetActive(false);
        playDeathSound.playSound();
        gameover.showGameOver();

    }
    public void characterStart(){
        this.gameObject.SetActive(true);
    }
}
