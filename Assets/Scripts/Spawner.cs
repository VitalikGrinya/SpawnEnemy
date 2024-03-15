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

        StartCoroutine(Spawn(waitForSeconds));
    }

    private IEnumerator Spawn(WaitForSeconds waitForSeconds)
    {
        while(true)
        {
            ActivateSpawnPoint();

            yield return waitForSeconds;
        }
    }

    private void ActivateSpawnPoint()
    {
        int currentSpawnPoint = Random.Range(_minRandomValue, _maxRandomValue);

        SpawnPoint spawnPoint = _spawnPoint[currentSpawnPoint];

        spawnPoint.Spawn();
    }
}
