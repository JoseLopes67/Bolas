using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector3 lvelocity;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(100f, 100f, 0f));
    }

    // Update is called once per frame
    void Update()
    {
        lvelocity = rb.velocity;
        HandleUpdate();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bounce(collision, lvelocity);
    }

    public virtual void Bounce(Collision2D collision, Vector3 velocity)
    {
        var speed = lvelocity.magnitude;
        var direction = Vector3.Reflect(lvelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed, 0f);
    }

    public virtual void HandleUpdate()
    {

    }

    public void Shrink()
    {
        Vector2 shrink = new Vector2(0.5f, 0.5f);
        transform.localScale = shrink;
    }

    public void Growth()
    {
        Vector2 growth = new Vector2(1f, 1f);
        transform.localScale = growth;
    }

}


