using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGreen : MonoBehaviour
{
    public GameObject ballPrefab; // Assign the Ball Prefab in the Inspector
    private GameObject currentBall;

    void Start()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        // Instantiate a new ball from the prefab
        currentBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }

    public void RespawnBall()
    {
        // Destroy the current ball
        Destroy(currentBall);

        // Call the SpawnBall function to create a new ball
        SpawnBall();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            RespawnBall();
        }
    }
}
