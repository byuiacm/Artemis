using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 2.0f;
    private Vector3 screenBounds;
    private int count = 0;
    List<GameObject> asteroids;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Screen.height));
        StartCoroutine(asteroidWave());
        asteroids = new List<GameObject>();
    }

    private Vector3 getSpawnLocation()
    {
        Vector3 startPosition;
        count++;
        int condition = count % 4;
        
        
      switch (condition)
      {
            case 1:
                startPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), 0 , -screenBounds.z);
                break;
            case 2:
                startPosition = new Vector3(screenBounds.x, 0,Random.Range(-screenBounds.z, screenBounds.z));
                break;
            case 3:
                startPosition = new Vector3(-screenBounds.x, 0, Random.Range(-screenBounds.z, screenBounds.z));
                break;
            default:
                startPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), 0, screenBounds.z);
                break;
      }

        return startPosition;
    }

    private void spawnEnemy()
    { 
        if (asteroids.Count < 10)
        {
            GameObject a = Instantiate(asteroidPrefab) as GameObject;
            asteroids.Add(a);
            a.transform.position = getSpawnLocation();
        }
    }

    private void checkAlive()
    {
        var toRemove = new List<GameObject>();
        foreach (GameObject p in asteroids)
        {
            if (p == null)
            {
                toRemove.Add(p);
            }
        }

        foreach (GameObject p in toRemove)
        {
            asteroids.Remove(p);
        }

    }

    // Update is called once per frame
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
            checkAlive();
        }
    }
}
