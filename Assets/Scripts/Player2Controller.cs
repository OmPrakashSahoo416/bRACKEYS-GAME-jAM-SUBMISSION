using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private Rigidbody2D player2Rb;
    Vector2 movePos;
    public float health=100f;
    float speed = 5f;
    public HealthBar healthBar;

    void Start()
    {
        player2Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosUpdate();
        healthBar.SetHealth(health);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == GameObject.FindWithTag("Bullet"))
        {
            health -= 5f;
        }
    }

    private void FixedUpdate()
    {
        player2Rb.MovePosition(player2Rb.position + movePos * speed * Time.fixedDeltaTime);
    }
    public void PlayerPosUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movePos.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movePos.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movePos.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movePos.x = 1;
        }
        if (!Input.anyKey)
        {
            movePos.x = 0;
            movePos.y = 0;
        }
    }
}
