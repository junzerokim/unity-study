using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float height = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y <= -7.5f) {
            // transform.position = new Vector3(0, 7.5f, 0);
            transform.position += new Vector3(0, height * 3f, 0); 
        }
    }
}
