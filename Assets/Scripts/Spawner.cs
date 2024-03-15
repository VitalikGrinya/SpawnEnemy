using System.Collections;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoint;

    private int _minRandomValue = 0;
    private int _maxRandomValue = 4;
    private int _spawnTime = 5;

    private void Start()
    {
        var waitForSeconds = new WaitForSeconds(_spawnTime);

        StartCoroutine(Spawning(waitForSeconds));
    }

    private IEnumerator Spawning(WaitForSeconds waitForSeconds)
    {
        while(true)
        {
            Spawn();

            yield return waitForSeconds;
        }
    }

    private void Spawn()
    {
        int currentSpawnPoint = Random.Range(_minRandomValue, _maxRandomValue);

        SpawnPoint spawnPoint = _spawnPoint[currentSpawnPoint];

        spawnPoint.Spawn();
    }
}
