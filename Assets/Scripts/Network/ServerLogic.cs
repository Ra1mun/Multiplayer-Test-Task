using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon.Pun;
using UnityEngine;

public class ServerLogic : MonoBehaviour
{
    private List<Player> _players = new List<Player>();

    public static bool GameIsStarted = false;

    public event Action GameOver;
    

    private void Start()
    {
        PhotonPeer.RegisterType(typeof(Vector2), 242, SerializeVector2, DeserializeVector2);
    }

    public void AddPlayer(Player player)
    {
        _players.Add(player);
        player.Health.OnDie += DestroyPlayer;
        player.Pocket.OnReachedMaxCoins += PlayerReachedMaxCoins;
    }

    private void PlayerReachedMaxCoins(string nickName)
    {
        Debug.Log($"{nickName} has won!");
        GameOver?.Invoke();
    }

    private void DestroyPlayer(Player player)
    {
        _players.Remove(player);
        Destroy(player);
    }
    
    public static object DeserializeVector2(byte[] data)
    {
        Vector2 result = new Vector2();

        result.x = (float) BitConverter.ToDouble(data, 0);
        result.y = (float) BitConverter.ToDouble(data, 16);

        return result;
    }

    public static byte[] SerializeVector2(object obj)
    {
        Vector2 vector2 = (Vector2)obj;
        byte[] result = new byte[8];
        
        BitConverter.GetBytes(vector2.x).CopyTo(result,0);
        BitConverter.GetBytes(vector2.x).CopyTo(result,16);

        return result;
    }
}
