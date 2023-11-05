using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isGameOver) {
            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                animator.SetBool("isRunning", true);
                spriteRenderer.flipX = true;
            } else if (Input.GetKey(KeyCode.RightArrow)) {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                animator.SetBool("isRunning", true);
                spriteRenderer.flipX = false;
            } else {
                animator.SetBool("isRunning", false);
            }
        } else {
            animator.SetBool("isRunning", false);
        }
    }

    public void GetRain() {
        GetComponent<SpriteRenderer>().color = new Color(0.64f, 0.64f, 0.64f);
    }
}
