using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update() {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space key is pressed.");
        }

    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
     private void OnCollisionEnter2D(Collision2D collision) {
        
        if (collision.gameObject.CompareTag("npc"))
        {
            Debug.Log("Collision with object having tag 'npc'");

        }

    }
}
