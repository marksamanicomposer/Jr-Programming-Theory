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
            gameManager.EndGame();
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            UpdateScore(50);
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
