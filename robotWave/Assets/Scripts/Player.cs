using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private HPBar hpBar;
    // Start is called before the first frame update
    void Start()
    {
        hpBar = GetComponentInChildren<HPBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
