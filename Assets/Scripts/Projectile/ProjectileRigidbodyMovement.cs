using System;
using UnityEngine;

public class ProjectileRigidbodyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;
    
    public void Move(Vector2 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction * _speed * Time.deltaTime);
    }
}
