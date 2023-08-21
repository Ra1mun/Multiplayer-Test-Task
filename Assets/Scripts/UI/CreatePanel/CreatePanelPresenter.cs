using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePanelPresenter 
{
    private readonly CreatePanelView _view;
    private readonly CreatePanelModel _model;
    private readonly CreatePanelData _data;

    public CreatePanelPresenter(CreatePanelView view, CreatePanelModel model, CreatePanelData data)
    {
        _model = model;
        _view = view;
        _data = data;
    }

    public void Enable()
    {
        _view.OnCreatedRoom += OnCreateRoom;
        _view.OnClose += OnClose;
        _view.OnOpenPanel += OnOpenPanel;
    }

    private void OnCreateRoom()
    {
        _model.OnCreatedRoom(_data.RoomName);
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
        _view.OnCreatedRoom -= OnCreateRoom;
        _view.OnClose -= OnClose;
        _view.OnOpenPanel -= OnOpenPanel;
    }
}
