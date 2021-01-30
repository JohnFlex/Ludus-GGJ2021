using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public static bool nowMoving = false;
    MainControls controls;
    float movePerformation = 0;

    public float jumpHeight = 1f;
    public float speed = 1f;


    Rigidbody2D rb;

    bool grounded = false;  
    

    private void Awake()
    {
        controls = new MainControls();

        controls.Default.Move.performed += ctx =>
        {
            nowMoving = true;
            movePerformation = ctx.ReadValue<float>();
        };
        controls.Default.Move.canceled += _ =>
        {
            nowMoving = false;
            movePerformation = 0f;
        };
        

        controls.Default.Jump.performed += _ => Jump();


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


    private void OnDisable()
    {
        controls.Default.Disable();
    }
}
