using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public taskbar taskbar;
    public Canvas gameOver;
    public GameObject enemyPrefab;
    public GameObject healthPoint;
    bool isHealthPoint;
    public GameObject fuelPrefab;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
        StartCoroutine(SpawnHealthPoint());
        StartCoroutine(SpawnFuel());
    }
    

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(enemyPrefab);
        }
        
    }

    IEnumerator SpawnHealthPoint()
    {
        while (true)
        {
            yield return new WaitForSeconds(20f);
            Instantiate(healthPoint);
        }

    }
    IEnumerator SpawnFuel()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            Instantiate(fuelPrefab);
        }

    }
    private void Update()
    {
        if (taskbar.taskBar.value == 10)
        {
            gameOver.gameObject.SetActive(true);
        }

        
    }

    public void OnrestartbuttonDown()
    {
        SceneManager.LoadScene(1);
    }
    public void OnquitbuttonDown()
    {
        Application.Quit();
    }
    public void OnmainmenubuttonDown()
    {
        SceneManager.LoadScene(0);
    }
}
