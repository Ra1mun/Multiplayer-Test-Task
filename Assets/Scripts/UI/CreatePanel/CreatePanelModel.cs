public class CreatePanelModel
{
    private readonly RoomHandler _roomHandler;

    public CreatePanelModel(RoomHandler roomHandler)
    {
        _roomHandler = roomHandler;
    }

    public void OnCreatedRoom(string roomName)
    {
        _roomHandler.CreateRoom(roomName);
    }
}
