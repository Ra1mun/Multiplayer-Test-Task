using TMPro;
using UnityEngine.UI;
public class CreatePanelData
{
    private readonly TMP_InputField _inputField;

    public string RoomName => _inputField.text;

    public CreatePanelData(TMP_InputField inputField)
    {
        _inputField = inputField;
    }
}
