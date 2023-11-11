using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
