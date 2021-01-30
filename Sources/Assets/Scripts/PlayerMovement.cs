using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    MainControls controls;
    float movePerformation = 0;

    public float jumpHeight = 1f;
    public float speed = 1f;


    Coroutine glide;

    Rigidbody2D rb;

    bool grounded = false;
    

    private void Awake()
    {
        controls = new MainControls();

        controls.Default.Move.performed += ctx => movePerformation = ctx.ReadValue<float>();
        controls.Default.Move.canceled += _ => movePerformation = 0f;
        

        controls.Default.Jump.performed += _ => Jump();

        controls.Default.Glide.performed += _ => glide = StartCoroutine(Glide());

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controls.Default.Enable();
    }

    private void FixedUpdate()
    {
        Move(movePerformation);   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }


    void Move(float moveDirection)
    {
        rb.AddForce(Vector2.right * moveDirection * speed, ForceMode2D.Impulse);
    }

    void Jump()
    {
        if (grounded)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }

    IEnumerator Glide()
    {
        yield return new WaitForEndOfFrame();
    }

    private void OnDisable()
    {
        controls.Default.Disable();
    }
}
