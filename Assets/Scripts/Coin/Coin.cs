using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent<PlayerPocket>(out PlayerPocket pocket))
        {
            pocket.CurrentCoins++;
            Destroy(gameObject);
        }
            
    }
}
