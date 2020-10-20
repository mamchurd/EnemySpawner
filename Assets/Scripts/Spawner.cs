using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private FootmanSpawner[] _footmanSpawners;

    private float _spawnTime;

    void Start()
    {
        _spawnTime = 2f;
        _footmanSpawners = FindObjectsOfType<FootmanSpawner>();

        StartCoroutine(SpawnFootman(_spawnTime));
    }

    private IEnumerator SpawnFootman(float timeToSpawn)
    {
        float currentTime = 0;

        while (true)
        {
            if (currentTime < timeToSpawn)
            {
                currentTime += Time.deltaTime;
            }
            else
            {
                _footmanSpawners[Random.Range(0, _footmanSpawners.Length)].Spawn();
                currentTime = 0;
            }

            yield return null;
        }
    }
}
