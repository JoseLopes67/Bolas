using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : Enemy
{
    private SpriteRenderer spriteRenderer;

    public Animator animator;

    public delegate void Powerup();
    public static Powerup powerup;

    public delegate void Powerdown();
    public static Powerdown powerdown;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        powerup += power;
        powerdown += crescer;
    }
    public override void Bounce(Collision2D collision, Vector3 velocity)
    {
        base.Bounce(collision, velocity);
        if(gameObject.tag == "Red" && collision.gameObject.tag == "Player")
        {
           
            Destroy(collision.gameObject);
        }
    }

    public void power()
    {
        rb.transform.localScale /= 2;
    }

    public void crescer()
    {
        rb.transform.localScale *= 2;
    }
}
