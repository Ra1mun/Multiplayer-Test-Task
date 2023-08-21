using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinPanelPresenter 
{
    private readonly JoinPanelView _view;
    private readonly JoinPanelModel _model;
    private readonly JoinPanelData _data;

    public JoinPanelPresenter(JoinPanelView view, JoinPanelModel model, JoinPanelData data)
    {
        _model = model;
        _view = view;
        _data = data;
    }

    public void Enable()
    {
        _view.OnJoinedRoom += OnJoinedRoom;
        _view.OnClose += OnClose;
        _view.OnOpenPanel += OnOpenPanel;
    }

    private void OnJoinedRoom()
    {
        _model.OnJoinedRoom(_data.RoomName);
    }

    private void OnClose()
    {
        _view.Close();
    }

    private void OnOpenPanel()
    {
        _view.Open();
    }

    public void Disable()
    {
        _view.OnJoinedRoom -= OnJoinedRoom;
        _view.OnClose -= OnClose;
        _view.OnOpenPanel -= OnOpenPanel;
    }
}
