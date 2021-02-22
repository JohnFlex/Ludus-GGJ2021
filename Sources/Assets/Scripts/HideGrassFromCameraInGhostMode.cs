using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideGrassFromCameraInGhostMode : MonoBehaviour
{

    bool visibleGrass = true;
    Camera cam;


    private void Awake()
    {
        cam = GetComponent<Camera>();
        TriggerVisibiliti.instance.trigger += DisplayGrass;
    }



    void DisplayGrass()
    {
        visibleGrass = !visibleGrass;
        if (visibleGrass)
        {
            cam.cullingMask |= (1 << LayerMask.NameToLayer("Grass"));

        }
        else
        {
            cam.cullingMask = ~(1 << LayerMask.NameToLayer("Grass"));
        }
    }
}
