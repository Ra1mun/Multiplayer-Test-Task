using System;
using Photon.Pun;
using Unity.VisualScripting;
using UnityEngine;

public class JoystickInput : MonoBehaviour
{
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private PlayerAttack _playerAttack;
    private FixedJoystick _joystick;
    private InputHandler _input;
    private PhotonView _view;
    private Vector2 _direction;
    
    public event Action<Vector2> OnInput;
    
    private void OnEnable()
    {
        _input.OnJump += OnJump;
        _input.OnAttack += OnAttack;
    }
    
    private void Awake()
    {
        _view = GetComponent<PhotonView>();
        _joystick = FindObjectOfType(typeof(FixedJoystick)).GetComponent<FixedJoystick>();
        _input = FindObjectOfType(typeof(InputHandler)).GetComponent<InputHandler>();
    }
    
    private void FixedUpdate()
    {
        if(_view.IsMine == false && PhotonNetwork.CurrentRoom.PlayerCount < 2) 
            return;
        
        OnInput?.Invoke(new Vector2(_joystick.Horizontal, 0));
    }

    private void OnJump()
    {
        if(_view.IsMine == false && PhotonNetwork.CurrentRoom.PlayerCount < 2) 
            return;
        
        _playerJump.Jump();
    }

    private void OnAttack()
    {
        if(_view.IsMine == false && PhotonNetwork.CurrentRoom.PlayerCount < 2) 
            return;
        
        _playerAttack.PerformAttack();
    }

    private void OnDisable()
    {
        _input.OnJump -= OnJump;
        _input.OnAttack -= OnAttack;
    }

    
}
