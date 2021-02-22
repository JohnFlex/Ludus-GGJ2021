using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Hero;
    public float DistanceCamera = 2.0f;

    private void Awake() 
    {
        GetComponent <UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / DistanceCamera);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(Hero.position.x, Hero.position.y, Hero.position.z-10);
    }
}
