using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private HPBar hpBar;
    [SerializeField]
    private float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hpBar = GetComponentInChildren<HPBar>();
    }

    // Update is called once per frame
    void Update()
    {
         float horizontalInput = Input.GetAxisRaw("Horizontal");
         float verticalInput = Input.GetAxisRaw("Vertical");
         Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f).normalized;
         transform.position += moveTo * moveSpeed * Time.deltaTime;

         if (moveTo != Vector3.zero) {
            animator.SetBool("isWalking", true);
         } else {
            animator.SetBool("isWalking", false);
         }

         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
         Vector3 direction = mousePos - transform.position;
         Vector3 currentScale = transform.localScale;
         Vector3 currentHpBarScale = hpBar.transform.localScale;

         if (direction.x > 0) {
            transform.localScale = new Vector3(Mathf.Abs(currentScale.x), currentScale.y, currentScale.z);
            hpBar.transform.localScale = new Vector3(Mathf.Abs(currentHpBarScale.x), currentHpBarScale.y, currentHpBarScale.z);
         } else {
            transform.localScale = new Vector3(-Mathf.Abs(currentScale.x), currentScale.y, currentScale.z);
            hpBar.transform.localScale = new Vector3(-Mathf.Abs(currentHpBarScale.x), currentHpBarScale.y, currentHpBarScale.z);
         }
    }
}
