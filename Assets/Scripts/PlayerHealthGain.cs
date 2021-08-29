using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthGain : MonoBehaviour
{
    PlayerHealthBar playerHealthBarScript;
    GameObject astronaut;

    private void Start()
    {
        playerHealthBarScript = GameObject.Find("HealthBarPlayer").GetComponent<PlayerHealthBar>();
        astronaut = GameObject.Find("Astronaut");
        transform.position = RandomSpawnPos();
        StartCoroutine(DestroyHealthPoint());
    }
    public Vector2 RandomSpawnPos()
    {
        return new Vector2(Random.Range(-15f, 10f), Random.Range(3f, 30f));
    }

    IEnumerator DestroyHealthPoint()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == astronaut)
        {
            Destroy(gameObject);
            playerHealthBarScript.health += 25;
            if (playerHealthBarScript.health >= 50)
            {
                playerHealthBarScript.health = 50;
            }
        }
        
    }
}
