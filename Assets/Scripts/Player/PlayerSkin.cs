using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;


[RequireComponent(typeof(PhotonView))]
public class PlayerSkin : MonoBehaviour
{
    [SerializeField] private Sprite _enemySkin;
    [SerializeField] private Sprite _selfSkin;
    private SpriteRenderer _spriteRenderer;
    private PhotonView _view;
    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _view = GetComponent<PhotonView>();
    }

    private void Start()
    {
        _spriteRenderer.sprite = _view.IsMine ?  _selfSkin : _enemySkin;
    }
}
