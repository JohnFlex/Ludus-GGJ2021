using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVisibiliti : MonoBehaviour
{
    MainControls controls;
    public static TriggerVisibiliti instance;

    public delegate void TriggerVisibleItems();
    public event TriggerVisibleItems trigger;

    private void Awake()
    {
        instance = new TriggerVisibiliti();

        instance.controls = new MainControls();

        instance.controls.Default.ChangeWorld.performed += _ => instance.trigger();

        instance.controls.Default.Enable();

    }

}
