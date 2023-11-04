using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] rains;

    [SerializeField]
    private float rainInterval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    private void StartSpawning() {
        StartCoroutine(SpawnRainRoutine());
    }

    private void StopSpawning() {
        StopCoroutine(SpawnRainRoutine());
    }

    IEnumerator SpawnRainRoutine() {
        yield return new WaitForSeconds(0.5f);
        while (true) {
            SpawnRain();
            yield return new WaitForSeconds(rainInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRain() {
        float posX = Random.Range(-3f, 3f);
        Vector3 position = new Vector3(posX, 6, 0);
        int index = Random.Range(0, rains.Length);
        Instantiate(rains[index], position, Quaternion.identity);
    }
}
