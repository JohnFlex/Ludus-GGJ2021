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

    [SerializeField]
    AudioClip jumpClip;

    [SerializeField]
    AudioClip walkingClip;

    [SerializeField]
    AudioClip fallClip;

    AudioSource audioSource;

    Coroutine soundCoroutine;
    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();

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
            audioSource.Stop();
        };
        

        controls.Default.Jump.performed += _ => Jump();


        
        
    }

    private void OnEnable()
    {
        controls.Default.Enable();
    }

    private void FixedUpdate()
    {
        Move(movePerformation);
        if (Mathf.Approximately(rb.velocity.magnitude, Vector2.zero.magnitude))
        {
            //audioSource.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            audioSource.PlayOneShot(fallClip, 1f);
            grounded = true;
            Debug.Log("Enter Ground");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
            Debug.Log("Quit ground");
            
        }
    }


    void Move(float moveDirection)
    {
        rb.AddForce(Vector2.right * moveDirection * speed, ForceMode2D.Impulse);

        if (grounded && !audioSource.isPlaying && !Mathf.Approximately(rb.velocity.magnitude, Vector2.zero.magnitude))
        {
            Debug.Log("INDALOOP");
            //audioSource.Play();
            
        }
    }

    void Jump()
    {
        if (grounded)
        {
            audioSource.PlayOneShot(jumpClip);
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }


    private void OnDisable()
    {
        controls.Default.Disable();
    }

   
}
