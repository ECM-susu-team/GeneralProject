using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{

    public Transform[] spawnPoints;  // Array of spawn points to be used.
    public GameObject[] enemyPrefabs; // Array of different Enemies that are used.
    public int amountEnemies = 20;  // Total number of enemies to spawn.
    public int yieldTimeMin = 2;  // Minimum amount of time before spawning enemies randomly.
    public int yieldTimeMax = 5;  // Don't exceed this amount of time between spawning enemies randomly.
    private int i;

    void Start()
    {
        Spawn(1);
    }

    public void Spawn(int amountEnemies)
    {
        for (i = 0; i < amountEnemies; i++) // How many enemies to instantiate total.
        {
            //  yield WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));  // How long to wait before another enemy is instantiated.

            GameObject obj = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]; // Randomize the different enemies to instantiate.
            Transform pos = spawnPoints[Random.Range(0, spawnPoints.Length)];  // Randomize the spawnPoints to instantiate enemy at next.

            Instantiate(obj, pos.position, pos.rotation);

        }
    }
}