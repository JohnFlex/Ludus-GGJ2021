using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostModePlayer : MonoBehaviour
{
    public CameraFollow cameraScript;

    public GameObject ghostPanelIndicator;

    public GameObject defaultPlayer;

    public bool isInGhostMode = false;

    public float maxSpeed = 10F;

    MainControls controls;
    Vector2 movePerformation;

    Rigidbody2D rb;

    SpriteRenderer rd;

    [SerializeField]
    int maxStamina = 10;
    public int stamina;
    public int useStaminaTime = 1;
    int recoveryStaminaTime = 3;
    Coroutine useStamina;
    Coroutine recoverStamina;

    

    private void Awake()
    {
        controls = new MainControls();

        controls.GhostMode.Movement.performed += _ => movePerformation = _.ReadValue<Vector2>();
        controls.GhostMode.Movement.canceled += _ => movePerformation = Vector2.zero;


        rb = GetComponent<Rigidbody2D>();
        rd = GetComponent<SpriteRenderer>();
        stamina = maxStamina;
    }

    private void OnEnable()
    {
        controls.GhostMode.Enable();
    }

    private void OnDisable()
    {
        controls.GhostMode.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

        TriggerVisibiliti.instance.trigger += TriggerTheVisibility;
    }

    void TriggerTheVisibility()
    {
        isInGhostMode = !isInGhostMode;

        ghostPanelIndicator.SetActive(isInGhostMode);

        defaultPlayer.GetComponent<PlayerMovement>().enabled = !isInGhostMode;

        rd.enabled = isInGhostMode;

        transform.position = defaultPlayer.transform.position;

        if (isInGhostMode)
        {
            cameraScript.Hero = transform;
            if (recoverStamina != null)
            {
                StopCoroutine(recoverStamina);
            }

            useStamina = StartCoroutine(UseStamina());


        }
        else
        {
            cameraScript.Hero = defaultPlayer.transform;
            
            if (useStamina != null)
            {
                StopCoroutine(useStamina);
            }

            recoverStamina = StartCoroutine(RecoverStamina());
        }
    }

    private void FixedUpdate()
    {

        if ((rb.velocity.x < maxSpeed )&& rb.velocity.y < maxSpeed)
        {
            rb.AddForce(movePerformation.normalized, ForceMode2D.Impulse);
        }

        if (stamina < 0 && !isInGhostMode && recoverStamina == null)
        {
            recoverStamina = StartCoroutine(RecoverStamina());
        }
    }

    IEnumerator UseStamina()
    {
        for (int i = 0; i < maxStamina+1; i++)
        {
            if (stamina <= 0)
            {
                TriggerVisibiliti.TriggerVisibilityFromExternal();
            }

            stamina--;

            yield return new WaitForSeconds(useStaminaTime);
        }
    }

    IEnumerator RecoverStamina()
    {
        for (int i = 0; i < maxStamina; i++)
        {
            if (stamina >= maxStamina)
            {
                if (recoverStamina != null)
                {
                    StopCoroutine(recoverStamina);

                }
                
                stamina = maxStamina;
            }

            stamina++;

            yield return new WaitForSeconds(recoveryStaminaTime);
        }
    }

}
