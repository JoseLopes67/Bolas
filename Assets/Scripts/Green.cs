using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : Enemy
{

    Vector2 Position;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject power;



    public float seconds = 1f;

   


    private void Awake()
    {
        Position = transform.position;
        
    }

    



    public override void Bounce(Collision2D collision, Vector3 velocity)
    {
        base.Bounce(collision, velocity);
        if (gameObject.tag == "Green" && collision.gameObject.tag == "Player")
        {
            Respawn();

            if (Random.Range(0f, 1f) < 0.5f)
            {
                // Spawn enemyPrefab1
                SpawnRed(enemy1);
            }
            else
            {
                // Spawn enemyPrefab2
                SpawnRed(enemy2);
            }

        }
    }

    public override void HandleUpdate()
    {
        base.HandleUpdate();
        seconds -= Time.deltaTime;

       

            if (seconds <= 0 && power != null)
            {
               SpawnPower(power);
               seconds = 10;
            }
    }

    

    void Respawn()
    {
        SpawnBall();
        
    }

    void SpawnBall()
    {
        transform.position = new Vector3(
            Random.Range(-8.60f, 8.60f),
            Random.Range(-3.30f, 3.30f),
            0
        ); ;

       
    }

    void SpawnRed(GameObject enemy1)
    {
        transform.position = new Vector3(
            Random.Range(-8.60f, 8.60f),
            Random.Range(-3.30f, 3.30f),
            0
        ); ;

        Instantiate(enemy1, Position, Quaternion.identity);
    }

    void SpawnPower(GameObject power)
    {
        transform.position = new Vector3(
            Random.Range(-8.60f, 8.60f),
            Random.Range(-3.30f, 3.30f),
            0
        ); ;

        Instantiate(power, Position, Quaternion.identity);
    }







}
