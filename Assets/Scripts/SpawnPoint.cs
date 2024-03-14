using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemies _enemy;
    [SerializeField] private Vector3 _position;

    public void Spawn()
    {
        var enemy = Instantiate(_enemy, _position, Quaternion.identity);
    }
}
