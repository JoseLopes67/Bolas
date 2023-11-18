using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private Levels level;

    private Score score;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);

        score = GetComponent<Score>();

        level = GetComponent<Levels>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
