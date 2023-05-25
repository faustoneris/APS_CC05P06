using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float spawnerDelay = 0.85f;

    public GameObject carPrefab;

    private float nextTimeToSpawn;

    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time) {
            SpawnCar();

            nextTimeToSpawn = Time.time + spawnerDelay;
        }
    }

    void SpawnCar() {
        Instantiate(carPrefab, transform.position, transform.rotation);
    }
}
