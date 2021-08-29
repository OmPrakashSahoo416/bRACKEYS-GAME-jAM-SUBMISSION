using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject todoPlacePrefab;

    private void Start()
    {
        transform.position = RandomSpawnPos();
       
        astronaut = GameObject.Find("Astronaut");
       
        
    }
    public Vector2 RandomSpawnPos()
    {
        return new Vector2(Random.Range(-15f, 10f), Random.Range(3f, 30f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == astronaut)
        {
            Destroy(gameObject);
            Instantiate(todoPlacePrefab);
           
            
            
            
         
        }
        

    }
}
