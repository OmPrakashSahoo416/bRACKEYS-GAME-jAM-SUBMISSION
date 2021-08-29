using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb;
    Vector2 mousePos;
    float speed = 5f;
    Vector2 movePos;
    float angle;
    public Camera mainCam;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            movePos.y = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            movePos.y = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            movePos.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            movePos.x = 1;
        }
        if( !Input.anyKey)
        {
            movePos.x = 0;
            movePos.y = 0;
        }

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movePos * speed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - playerRb.position;
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        playerRb.rotation = angle-90f;

    }
}
