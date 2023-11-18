using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class NewScore : MonoBehaviour
{
    public static NewScore instance;
   
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); 
        }
    }


    void Update()
    {

    }

    

   
}

