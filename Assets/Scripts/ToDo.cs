using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDo : MonoBehaviour
{
    public taskbar taskbar;
    public float timer=0f;
    private void Start()
    {
        transform.position = RandomSpawnPos();
        taskbar = GameObject.Find("TaskBar").GetComponent<taskbar>();
        
    }

    private void Update()
    {
        timer += Time.deltaTime;
        taskbar.SetValue(timer);
    }

    public Vector2 RandomSpawnPos()
    {
        return new Vector2(Random.Range(-15f, 10f), Random.Range(3f, 30f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameObject.Find("Astronaut"))
        {
            Destroy(gameObject);
            timer = 0f;
        }
    }
    
}
