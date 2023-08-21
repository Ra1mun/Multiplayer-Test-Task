using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class RoomHandler : MonoBehaviourPunCallbacks
{
    [SerializeField] private int MaxPlayers;

    public void CreateRoom(string roomName)
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = MaxPlayers;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }
    
    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
