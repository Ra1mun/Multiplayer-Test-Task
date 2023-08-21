using System;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Transform _groundChecker;
    [SerializeField] private ForceMode2D _forceMode;
    [SerializeField] private float _force;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private JoystickInput _joystickInput;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    public void Jump()
    {
        if (IsGrounded())
        {
            _rigidbody2D.AddForce(Vector2.up * _force, _forceMode);
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckSphere(_groundChecker.position, 0f, _layerMask);
    }
}
