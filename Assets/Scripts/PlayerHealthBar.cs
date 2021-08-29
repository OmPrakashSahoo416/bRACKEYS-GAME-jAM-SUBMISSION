using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Canvas gameOver;
    public float health = 50f;

    private void Update()
    {
        
        health -= Time.deltaTime;
        healthBar.value = health;
        if (healthBar.value == 0)
        {
            gameOver.gameObject.SetActive(true);
        }
    }
}
