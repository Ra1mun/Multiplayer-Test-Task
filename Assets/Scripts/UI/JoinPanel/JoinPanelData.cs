using TMPro;
using UnityEngine.UI;
public class JoinPanelData
{
    private readonly TMP_InputField _inputField;

    public string RoomName => _inputField.text;

    public JoinPanelData(TMP_InputField inputField)
    {
        _inputField = inputField;
    }
}
