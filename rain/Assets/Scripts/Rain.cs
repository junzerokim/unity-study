using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField]
    private GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnCollisionEnter2D(Collision2D other) {
        // Debug.Log("On Collision");
    // }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ground") {
            Instantiate(particle, transform.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject, 0.5f);
        } else if (other.gameObject.tag == "Player") {
            Instantiate(particle, transform.position, Quaternion.identity);
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
