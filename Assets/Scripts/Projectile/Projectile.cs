using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private ProjectileRigidbodyMovement _movement;
    private void FixedUpdate()
    {
        _movement.Move(transform.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerHealth damagable))
        {
            damagable.ApplyDamage(_damage);
        }
        Destroy(gameObject); 
    }
}
