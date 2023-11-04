using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [SerializeField] // 밖에서는 접근 불가능하지만 유니티에서는 접근 가능
    private float moveSpeed;

    [SerializeField]
    private float posX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x <= -posX) {
            transform.position = new Vector3(posX, 0, 0);
        }
    }
}
