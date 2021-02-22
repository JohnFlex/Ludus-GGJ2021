using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{

    public int defaultLevelTime = 120;
    int _actualTime;
    public int actualTime
    {
        get
        {
            return _actualTime;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _actualTime = defaultLevelTime;
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            if (_actualTime <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            _actualTime--;
            yield return new WaitForSeconds(1);
        }
    }
}
