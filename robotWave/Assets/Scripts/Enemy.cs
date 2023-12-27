using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform targetTransform;
    private HPBar hpBar;

    [SerializeField]
    private float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
        hpBar = GetComponentInChildren<HPBar>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveTo = (targetTransform.position - transform.position).normalized;
        transform.position += moveTo * moveSpeed * Time.deltaTime;
    }
}
