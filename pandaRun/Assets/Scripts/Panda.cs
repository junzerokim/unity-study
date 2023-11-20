using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panda : MonoBehaviour
{
  private Rigidbody2D rigidBody;
  [SerializeField]
  private float jumpForce = 10f;
  // Start is called before the first frame update
  void Start()
  {
    rigidBody = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.UpArrow))
    {
      Jump();
    }
  }

  private void Jump()
  {
    rigidBody.velocity = Vector2.up * jumpForce;
  }
}
