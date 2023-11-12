using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public float moveSpeed = 5f;
    private int obstacleCount = 0;

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
}
