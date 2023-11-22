using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;

    private float[] arrCoinPosY = { -2.5f, -0.75f, 1f };
    private float objectInterval = 0.2f;
    private int coinCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartObjectSpawning();
    }

    private void StartObjectSpawning() {
        StartCoroutine("SpawnObjectRoutine");
    }

    public void StopObjectSpawning() {
        StopCoroutine("SpawnObjectRoutine");
    }

    IEnumerator SpawnObjectRoutine() {
        yield return new WaitForSeconds(1f);
        while (true) {
            SpawnObject();
            yield return new WaitForSeconds(objectInterval);
        }
    }

    private void SpawnObject() {
        // SpawnCoin
        int coinPosYIndex = GetCoinPosYIndex();
        SpawnCoin(coinPosYIndex);

        // SpawnObstacle
    }

    private int GetCoinPosYIndex() {
        if (coinCount < 15) {
            return 0;
        }
        
        if (coinCount % 10 == 9) { // 9, 19, 29, 39
            // middle
            return 1;
        } else if (coinCount % 10 == 0) { // 0, 10, 20, 30
            // high
            return 2;
        } else if (coinCount % 10 == 1) { // 1, 11, 21, 31
            // middle
            return 1;
        } else {
            // low
            return 0;
        }
    }

    private void  SpawnCoin(int index) {
        // float posY = Random.Range(-2.5f, 0.5f);
        float posY = arrCoinPosY[index];
        Vector3 position = new Vector3(transform.position.x, posY, transform.position.y);
        Instantiate(coin, position, Quaternion.identity);
        coinCount++;
    } 
}
