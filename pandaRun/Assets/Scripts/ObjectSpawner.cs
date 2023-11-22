using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject coin;
    [SerializeField]
    private float objectInterval = 0.2f;
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
        SpawnCoin();

        // SpawnObstacle
    }

    private void SpawnCoin() {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
        Instantiate(coin, position, Quaternion.identity);
    } 
}
