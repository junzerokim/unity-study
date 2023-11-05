using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private GameObject gameOverPanel;
    
    private int score = 0;
    public bool isGameOver = false;
    
    void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore() {
        score += 1;
        scoreText.text = "Score " + score;

        if (score % 10 == 0) {
               RainSpawner spawner = FindObjectOfType<RainSpawner>();
               if (spawner != null) {
                spawner.DecreaseRainInterval();
                Debug.Log("Level Upgrade");
               }
        }
    }

    public void SetGameOver() {
        if (isGameOver == false) {
            isGameOver = true;

            RainSpawner spawner = FindObjectOfType<RainSpawner>();
            if (spawner != null) {
                spawner.StopSpawning();
                // spawner.StopAllCoroutines();
            }
        }
        gameOverPanel.SetActive(true);
    }
}
