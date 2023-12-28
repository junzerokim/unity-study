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

        Vector3 currScale = transform.localScale;
        Vector3 currHpBarScale = hpBar.transform.localScale;
        if (moveTo.x > 0) {
            transform.localScale = new Vector3(-Mathf.Abs(currScale.x), currScale.y, currScale.z);
            hpBar.transform.localScale = new Vector3(-Mathf.Abs(currHpBarScale.x), currHpBarScale.y, currHpBarScale.z);
        } else {
            transform.localScale = new Vector3(Mathf.Abs(currScale.x), currScale.y, currScale.z);
            hpBar.transform.localScale = new Vector3(Mathf.Abs(currHpBarScale.x), currHpBarScale.y, currHpBarScale.z);
        }

        hpBar.SetHP(2f, 10f);
    }
}
