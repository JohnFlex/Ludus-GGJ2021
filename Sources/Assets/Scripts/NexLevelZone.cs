using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexLevelZone : MonoBehaviour
{
    [SerializeField]
    string nextSceneName;

    [SerializeField]
    AudioClip toPlayClip;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<AudioSource>().PlayOneShot(toPlayClip);
            Invoke("LoadDelayedScene", 2f);
        }
        else if (collision.gameObject.CompareTag("Ghost") && SceneManager.GetActiveScene().name != nextSceneName)
        {
            TriggerVisibiliti.TriggerVisibilityFromExternal();
        }
        
        
    }
    void LoadDelayedScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
