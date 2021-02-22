using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    MainControls controls;
    float movePerformation = 0;

    public float jumpHeight = 1f;
    public float speed = 0.4f;


    Coroutine glide;

    Rigidbody2D rb;

    bool grounded = false;

    float defaultGravityScale;
    public float glidingGravityScale = 0.5f;
    public bool canGlide = false;
    

    private void Awake()
    {
        controls = new MainControls();

        controls.Default.Move.performed += ctx => movePerformation = ctx.ReadValue<float>();
        controls.Default.Move.canceled += _ => movePerformation = 0f;
        

        controls.Default.Jump.performed += _ => Jump();

        controls.Default.Glide.performed += _ => StartGlide();
        controls.Default.Glide.canceled += _ => StopGlide();

        rb = GetComponent<Rigidbody2D>();

        defaultGravityScale = rb.gravityScale;
    }

    private void OnEnable()
    {
        controls.Default.Enable();
    }

    private void FixedUpdate()
    {
        Move(movePerformation);
        if (movePerformation != 0)
        {
            gameObject.GetComponent<Animator>().SetFloat(0, movePerformation);
        }
    }

    private void Update()
    {
        
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

    void  StartGlide()
    {
        if (canGlide)
        {
            rb.gravityScale = glidingGravityScale;
        }
        
    }

    void StopGlide()
    {
        rb.gravityScale = defaultGravityScale;
    }

    private void OnDisable()
    {
        controls.Default.Disable();
    }
}
