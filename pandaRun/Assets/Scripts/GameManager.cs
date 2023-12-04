using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private GameObject gameOverPanel;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    public bool isGameOver = false;

    private int score = 0;
    
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    public void AddScore() {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void SetGameOver() {
        if (isGameOver == false) {
            isGameOver = true;

            Panda panda = FindObjectOfType<Panda>();
            if (panda != null) {
                panda.SetGameOver();
            }

            ObjectSpawner spawner = FindObjectOfType<ObjectSpawner>();
            if (spawner != null) {
                spawner.StopObjectSpawning();
            }

            gameOverPanel.SetActive(true);
        }
    }

    public void RestartGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void ToHome() {
        SceneManager.LoadScene("MenuScene");
    }
}
