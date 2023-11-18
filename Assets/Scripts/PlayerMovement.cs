using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    

    public float speed = 5f;

    private float horizontal;
    private float vertical;

    public Animator animator;

    private bool isFacingRight = true;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, vertical * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(vertical));

    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal> 0f) {
        
            isFacingRight = !isFacingRight;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            
            Time.timeScale = 0f;
            SceneManager.LoadScene("Final");

        }

        if (collision.gameObject.CompareTag("Green"))
        {
            Score.instance.AddScore();
        }

    }
}
