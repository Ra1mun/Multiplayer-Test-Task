using System;
using Photon.Pun;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   private Player _player;
   private PhotonView _view;

   private int _currentHealth;
   
   public event Action<int> OnHealthChanged;
   public event Action<Player> OnDie;
   private void Awake()
   {
      _player = GetComponent<Player>();
      
      
      _currentHealth = _player.Config.MaxHealth;
   }

   public void ApplyDamage(int damage)
   {
      _currentHealth -= damage;
      OnHealthChanged?.Invoke(_currentHealth);
      if(_currentHealth == 0)
         OnDie?.Invoke(_player);
   }
}
