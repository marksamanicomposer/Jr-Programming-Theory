using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    [HideInInspector] public int score = 0;
    [HideInInspector] public int highScore;
    private Rigidbody rB;
    public GameManager gameManager;
    public AudioSource source;
    public AudioClip scream;
    public AudioClip cheer;

    private void Start()
    {
        rB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        scoreText.text = "Score: " + score;
        if (score > highScore)
            highScore = score;
        if (!scoreText.IsActive())
            score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Human")
        {
            Destroy(collision.gameObject);
            if(gameManager.canPlay)
                source.PlayOneShot(scream, 1.25f);
            gameManager.EndGame();
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            UpdateScore(50);
            if (gameManager.canPlay)
                source.PlayOneShot(cheer, 0.5f);
            Destroy(collision.gameObject);
            rB.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
        if (collision.gameObject.tag == "Ground")
            return;
    }

    void UpdateScore(int add)
    {
        score += add;
    }
}
