using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score = 0;
    
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    private void Start() {
        AddScore();
    }

    public void AddScore() {
        score += 1;
        scoreText.text = score.ToString();
    }
}
