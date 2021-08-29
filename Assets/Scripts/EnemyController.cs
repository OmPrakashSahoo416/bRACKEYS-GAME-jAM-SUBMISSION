using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform player2;
    float speed = 2.5f;
    Rigidbody2D enemyRb;
    Vector2 spawnPos;
    Player2Controller player2ControllerScript;
    
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player2 = GameObject.Find("Astronaut").transform;
        transform.position = RandomSpawnPos();
        player2ControllerScript = GameObject.Find("Astronaut").GetComponent<Player2Controller>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player2.gameObject)
        {
            player2ControllerScript.health -= 10f;
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Vector3 lookDirection = (player2.transform.position - transform.position).normalized;
        enemyRb.velocity=lookDirection * speed;
        
    }
    public Vector2 RandomSpawnPos()
    {
        return new Vector2(Random.Range(-15f, 10f), Random.Range(3f, 30f));
    }
    
}
