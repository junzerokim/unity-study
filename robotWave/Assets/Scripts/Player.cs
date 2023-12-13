using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private HPBar hpBar;
    [SerializeField]
    private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        hpBar = GetComponentInChildren<HPBar>();
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput = Input.GetAxisRaw("Horizontal");
         float verticalInput = Input.GetAxisRaw("Vertical");
         Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);
         transform.position += moveTo * moveSpeed * Time.deltaTime;
    }
}
