public class JoinPanelModel
{
    private readonly RoomHandler _roomHandler;

    public JoinPanelModel(RoomHandler roomHandler)
    {
        _roomHandler = roomHandler;
    }

    public void OnJoinedRoom(string roomName)
    {
        _roomHandler.JoinRoom(roomName);
    }
}
