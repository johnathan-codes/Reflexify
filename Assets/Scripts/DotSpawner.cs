using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotSpawner : MonoBehaviour
{
    public GameObject dot;
    float randomX;
    Vector2 spawnPoint;
    public float rangeLow, rangeHigh;
    public float respawnTime;
    float nextSpawn;

    public DotDespawner despawner;
    void Update()
    {
        if (Time.time > nextSpawn && despawner.koniec == false)
        {
            nextSpawn = Time.time + respawnTime;
            randomX = Random.Range(rangeLow, rangeHigh);
            spawnPoint = new Vector2(randomX, transform.position.y);
            Instantiate(dot, spawnPoint, Quaternion.identity);
        }
    }
}
