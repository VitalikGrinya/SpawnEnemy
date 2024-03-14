using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

        if(gameObject.transform.position == _target.position)
            Destroy(gameObject);
    }
}
