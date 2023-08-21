using System;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Button _jumpButton = null;
    [SerializeField] private Button _attackButton = null;

    public event Action OnJump;
    public event Action OnAttack;

    private void OnEnable()
    {
        _jumpButton.onClick.AddListener(OnJumpClick);
        _attackButton.onClick.AddListener(OnAttackClick);
    }

    private void OnJumpClick()
    {
        OnJump?.Invoke();
    }

    private void OnAttackClick()
    {
        OnAttack?.Invoke();
    }

    private void OnDisable()
    {
        _jumpButton.onClick.RemoveListener(OnJumpClick);
        _attackButton.onClick.RemoveListener(OnAttackClick);
    }
}
