using System;
using Photon.Pun;
using UnityEngine;

public class PlayerPocket : MonoBehaviour
{
    private Player _player;

    private int _currentCoins = 0;
    
    public event Action<int> OnCoinsChanged;
    public event Action<string> OnReachedMaxCoins;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    public int CurrentCoins
    {
        get => _currentCoins;
        set
        {
            _currentCoins = Mathf.Clamp(value, 0, Constants.MAXCOINS);
            if(_currentCoins == Constants.MAXCOINS)
                OnReachedMaxCoins?.Invoke(_player.NickName);
            OnCoinsChanged?.Invoke(_currentCoins);
        }
    }
}

