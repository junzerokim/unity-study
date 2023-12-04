using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScroll : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    private float minPosX = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isGameOver == false) {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            if (transform.position.x <= minPosX) {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            if (gameObject.tag == "Coin") {
                GameManager.instance.AddScore();
                Destroy(gameObject);
            } else if (gameObject.tag == "Obstacle") {
                GameManager.instance.SetGameOver();
            }
        }
    }
}
