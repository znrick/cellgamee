using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RawEnergySpawner : MonoBehaviour
{
    public GameObject RawEnergy;
    public float RESpawnSpeed;

    public float timeBtwSpawn;
    public float startTimeBtwSpawn = 5;
    public float decreaseTime;
    public float minTime = 0.65f;
    public int spawnSide;

    public Vector2 center;
    public Vector2 size;

    void Start()
    {
        InvokeRepeating("RESpawner", 0 , RESpawnSpeed);
        spawnSide = Random.Range(0, 4);
    }

    void Update()
    {
        if(timeBtwSpawn <= 0) {
            if(spawnSide == 0) {
                RESpawner();
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 1) {
                RESpawner();
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 2) {
                RESpawner();
                spawnSide = Random.Range(0, 4);
            }
            else if(spawnSide == 3) {
                RESpawner();
                spawnSide = Random.Range(0, 4);
            }
            timeBtwSpawn = startTimeBtwSpawn;
        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

    void RESpawner()
    {
        Vector2 position = center + new Vector2(Random.Range(-size.x / 2 , size.x / 2), Random.Range(-size.y / 2 , size.y / 2));

        GameObject ClonedRE = Instantiate(RawEnergy, position, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(center, size);
    }

}
