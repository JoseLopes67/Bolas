using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "PowerUp" && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Red.powerup();
            Focus.powerf();

            
        }
    }

   
}
