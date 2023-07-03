using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Button playButton;
    public GameObject spawnManager;
    public GameObject player;
    private int highScore;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        spawnManager.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = false;
        highScoreText.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        spawnManager.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = true;
        playButton.gameObject.SetActive(false);
        highScoreText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void EndGame()
    {
        spawnManager.SetActive(false);
        player.GetComponent<PlayerMovement>().enabled = false;
        playButton.gameObject.SetActive(true);
        highScore = player.GetComponent<ScoreCount>().highScore;
        highScoreText.text = "High Score: " + highScore;
        highScoreText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
    }
}
