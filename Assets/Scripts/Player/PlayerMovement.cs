using System;
using Photon.Pun;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private JoystickInput _joystickInput;
    private float _speed => _player.Config.MoveSpeed;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _joystickInput.OnInput += Move;
    }

    private void Move(Vector2 input)
    {
        GetFlipSprite(input);
        _rigidbody.MovePosition(_rigidbody.position + input * _speed);
    }

    private void GetFlipSprite(Vector2 direction)
    {
        _player.transform.rotation = direction.x > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
    }

    private void OnDisable()
    {
        _joystickInput.OnInput -= Move;
    }
}
