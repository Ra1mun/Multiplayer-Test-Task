using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreatePanelSetup : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private CreatePanelView _view;
    private CreatePanelModel _model;
    private CreatePanelPresenter _presenter;
    private CreatePanelData _data;
    
    [Header("Handlers")]
    [SerializeField] private RoomHandler _roomHandler;
    [SerializeField] private TMP_InputField _inputField;
    private void Awake()
    {
        _model = new CreatePanelModel(_roomHandler);
        _data = new CreatePanelData(_inputField);
        _presenter = new CreatePanelPresenter(_view, _model, _data);
        _presenter.Enable();
    }
    
    private void OnDisable()
    {
        _presenter.Disable();
    }
}
