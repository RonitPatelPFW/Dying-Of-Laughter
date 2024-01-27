using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;

    void Update() {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void dialogue(){
        
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
