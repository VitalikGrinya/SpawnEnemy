using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;
    [SerializeField] private Vector3 _position;

    public void Spawn()
    {
        var enemy = Instantiate(_enemy, _position, Quaternion.identity);

        enemy.Init(_target.transform);
    }
}
