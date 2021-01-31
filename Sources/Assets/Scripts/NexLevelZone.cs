using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevelZone : MonoBehaviour
{
    [SerializeField]
    string nextSceneName;

    [SerializeField]
    AudioClip winClip;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().PlayOneShot(winClip);
        Invoke("LoadDelayedScene", 2f);
    }
    void LoadDelayedScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
