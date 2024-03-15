using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _target;

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void Init(Transform target)
    {
        _target = target;
    }
}
