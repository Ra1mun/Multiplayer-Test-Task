using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JoinPanelSetup : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private JoinPanelView _view;
    private JoinPanelModel _model;
    private JoinPanelPresenter _presenter;
    private JoinPanelData _data;
    
    [Header("Handlers")]
    [SerializeField] private RoomHandler _roomHandler;
    [SerializeField] private TMP_InputField _inputField;
    private void Awake()
    {
        _model = new JoinPanelModel(_roomHandler);
        _data = new JoinPanelData(_inputField);
        _presenter = new JoinPanelPresenter(_view, _model, _data);
        _presenter.Enable();
    }
    
    private void OnDisable()
    {
        _presenter.Disable();
    }
}
