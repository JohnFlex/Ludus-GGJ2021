using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnnemyCollider : MonoBehaviour
{
    public float repulseForce = 50f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * repulseForce, ForceMode2D.Impulse);
            Destroy(transform.parent.gameObject);
        }
    }
}
