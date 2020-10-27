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

        StartCoroutine(SpawnFootman());
    }

    private IEnumerator SpawnFootman()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_spawnTime);

        while (true)
        {
            _footmanSpawners[Random.Range(0, _footmanSpawners.Length)].Spawn();

            yield return waitForSeconds;
        }
    }
}
