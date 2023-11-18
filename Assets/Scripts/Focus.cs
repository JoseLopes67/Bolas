using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Red;

public class Focus : Enemy
{
    public delegate void PowerFocus();
    public static PowerFocus powerf;

    GameObject player;

    float bounce = 5;

    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.Find("Player");

        powerf += power;
    }

    public override void Bounce(Collision2D collision, Vector3 velocity)
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;

        rb.velocity = direction * bounce;

        if (gameObject.tag == "Red" && collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    public void power()
    {
        rb.transform.localScale /= 2;
    }
}
