using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerWood : MonoBehaviour
{
    public float spawnerDelayWood = 3;
    public float spawnerDelayFish = 2;

    public GameObject troncoPrefab;
    public GameObject peixePrefab;

    private float nextTimeToSpawnWood;
    private float nextTimeToSpawnFish;

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawnWood <= Time.time ||
            nextTimeToSpawnWood < nextTimeToSpawnFish) {
            SpawnWood();

            nextTimeToSpawnWood = Time.time + spawnerDelayWood;
        }

        if (nextTimeToSpawnFish <= Time.time ||
            nextTimeToSpawnFish > nextTimeToSpawnWood) {
            SpawnFish();

            nextTimeToSpawnFish = Time.time + spawnerDelayFish;
        }

    }

    void SpawnWood() {
        Instantiate(troncoPrefab, transform.position, transform.rotation);
    }
    void SpawnFish() {
        Instantiate(peixePrefab, transform.position, transform.rotation);
    }

}
