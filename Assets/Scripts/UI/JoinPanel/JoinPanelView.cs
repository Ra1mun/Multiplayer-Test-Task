using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoinPanelView : MonoBehaviour
{
    [SerializeField] private Button _joinRoomButton;
    [SerializeField] private Button _openPanelButton;
    [SerializeField] private Button _closeButton;

    private CanvasGroup _canvasGroup;
    
    public event Action OnOpenPanel;
    public event Action OnClose;
    public event Action OnJoinedRoom;
    
    private void OnEnable()
    {
        _openPanelButton.onClick.AddListener(OnOpenPanelClick);
        _closeButton.onClick.AddListener(OnCloseClick);
        _joinRoomButton.onClick.AddListener(OnJoinedRoomClick);
    }

    private void OnOpenPanelClick()
    {
        OnOpenPanel?.Invoke();
    }
    
    private void OnJoinedRoomClick()
    {
        OnJoinedRoom?.Invoke();
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
        _openPanelButton.onClick.RemoveListener(OnOpenPanelClick);
        _closeButton.onClick.RemoveListener(OnCloseClick);
        _joinRoomButton.onClick.RemoveListener(OnJoinedRoomClick);
    }

}
