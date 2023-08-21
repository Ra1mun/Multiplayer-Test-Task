using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePanelView : MonoBehaviour
{
    [SerializeField] private Button _createRoomButton;
    [SerializeField] private Button _openPanelButton;
    [SerializeField] private Button _closeButton;

    private CanvasGroup _canvasGroup;

    public event Action OnCreatedRoom;
    public event Action OnOpenPanel;
    public event Action OnClose;
    private void OnEnable()
    {
        _createRoomButton.onClick.AddListener(OnCreatedRoomClick);
        _openPanelButton.onClick.AddListener(OnCreatedClick);
        _closeButton.onClick.AddListener(OnCloseClick);
    }

    private void OnCreatedRoomClick()
    {
        OnCreatedRoom?.Invoke();
    }
    
    private void OnCreatedClick()
    {
        OnOpenPanel?.Invoke();
    }

    private void OnCloseClick()
    {
        OnClose?.Invoke();
    }

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Open()
    {
        _canvasGroup.Open();
    }

    public void Close()
    {
        _canvasGroup.Close();
    }
    private void OnDisable()
    {
        _createRoomButton.onClick.RemoveListener(OnCreatedRoomClick);
        _openPanelButton.onClick.RemoveListener(OnCreatedClick);
        _closeButton.onClick.RemoveListener(OnCloseClick);
    }
}
