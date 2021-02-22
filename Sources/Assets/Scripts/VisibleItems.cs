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
    BoxCollider2D myCollider;
    SpriteRenderer myRendere;
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
        myCollider = gameObject.GetComponent<BoxCollider2D>();
        myRendere = gameObject.GetComponent<SpriteRenderer>();
        TriggerTheVisibility();
    }

    void TriggerTheVisibility()
    {
        nowVisibleStatus = !nowVisibleStatus;
        if (nowVisibleStatus)
        {
            
            //myCollider.enabled = true;
            myRendere.enabled = true;
        }
        else
        {
            //myCollider.enabled = false;
            myRendere.enabled = false;
        }
    }

    private void OnDestroy()
    {
        TriggerVisibiliti.instance.trigger -= TriggerTheVisibility;
    }


}
