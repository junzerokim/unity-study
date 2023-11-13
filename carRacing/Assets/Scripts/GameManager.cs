using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverPanel;
    public static GameManager instance = null;
    public float moveSpeed = 5f;
    private int obstacleCount = 0;
    public bool isGameOver = false;

    private void Awake() {
        if (instance == null){
            instance = this;
        }
    }

    public void IncreaseSpeed() {
        moveSpeed += 2f;
    }

    public void AddObstacleCount() {
        obstacleCount += 1;
        if (obstacleCount % 10 == 0) {
            IncreaseSpeed();

            ObstacleSpawner spawner = FindObjectOfType<ObstacleSpawner>();
            if (spawner != null) {
                spawner.DecreaseObstacleInterval();
            }
        }
    }

    public void SetGameOver() {
        if (isGameOver == false) {
            isGameOver = true;

            ObstacleSpawner spawner = FindObjectOfType<ObstacleSpawner>();
            if (spawner != null) {
                spawner.StopSpawning();
            }

            StartCoroutine(ShowGameOverPanel());
        }
    }

    IEnumerator ShowGameOverPanel() {
        yield return new WaitForSeconds(1f);
        if (gameOverPanel != null) {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart() {
        SceneManager.LoadScene("PlayScene");
    }

    public void Home() {
        SceneManager.LoadScene("HomeScene");
    }
}
