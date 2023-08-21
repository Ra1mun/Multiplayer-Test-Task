using System;
using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerConfig _config;
    [SerializeField] private PlayerPocket _playerPocket;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private PhotonView _view;
    public PlayerConfig Config => _config;
    public PlayerPocket Pocket => _playerPocket;
    public PlayerHealth Health => _playerHealth;
    public string NickName => _view.Owner.NickName;

    private void Start()
    {
        FindObjectOfType<ServerLogic>().AddPlayer(this);
    }
}
