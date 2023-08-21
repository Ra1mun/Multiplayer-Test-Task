using System;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour, IPunObservable
{
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private List<Vector2> _spawnPoints;
    private PhotonView _view;
    private Vector2 _lastSpawnPoint;
    
    private void Awake()
    {
        _view = GetComponent<PhotonView>();
    }

    private void Start()
    {
        var spawnPoint = _spawnPoints.GetRandomItem();
        RemoveFillPoint(spawnPoint);
        _lastSpawnPoint = spawnPoint;
        PhotonNetwork.Instantiate(_playerPrefab.name, spawnPoint, Quaternion.identity);
    }

    private void RemoveFillPoint(Vector2 point)
    {
        _spawnPoints.Remove(point);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(_lastSpawnPoint);
        }
        else
        {
            _spawnPoints.Remove((Vector2) stream.ReceiveNext());
        }
    }
}
