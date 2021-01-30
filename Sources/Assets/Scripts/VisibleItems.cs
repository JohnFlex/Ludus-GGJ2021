using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleItems : MonoBehaviour
{
    public bool defaultVisible = false;
    bool nowVisibleStatus;

    [SerializeField]
    Sprite visibleSprite;

    [SerializeField]
    Sprite ghostSprite;

    Sprite spriteComponent;
    BoxCollider2D collider2D;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteComponent = gameObject.GetComponent<Sprite>();
        TriggerVisibiliti.instance.trigger += TriggerTheVisibility;
        nowVisibleStatus = !defaultVisible;
        if (defaultVisible)
        {
            spriteComponent = visibleSprite;

        }
        else
        {
            spriteComponent = ghostSprite;
        }
        collider2D = gameObject.GetComponent<BoxCollider2D>();
        renderer = gameObject.GetComponent<SpriteRenderer>();
        TriggerTheVisibility();
    }

    void TriggerTheVisibility()
    {
        nowVisibleStatus = !nowVisibleStatus;
        if (nowVisibleStatus)
        {
            
            collider2D.enabled = true;
            renderer.enabled = true;
        }
        else
        {
            collider2D.enabled = false;
            renderer.enabled = false;
        }
    }

    private void OnDestroy()
    {
        TriggerVisibiliti.instance.trigger -= TriggerTheVisibility;
    }


}
