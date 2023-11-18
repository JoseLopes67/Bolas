using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    

    public string levelLoad;
    public string levelFinal;
    public float seconds = 60f;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
      
    }

    

    // Update is called once per frame
    void Update()
    {
        

        seconds -= Time.deltaTime;

        

        if (seconds <= 30 && SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(levelLoad);
        }
        else if (seconds <= 0 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(levelFinal);
            Reset();
        }

        DontDestroyOnLoad(gameObject);

    }

    private void Reset()
    {
        if(seconds <= 0)
        {
            seconds = 60;
            seconds -=Time.deltaTime;
            Time.timeScale = 0f;
        }
    }

}
