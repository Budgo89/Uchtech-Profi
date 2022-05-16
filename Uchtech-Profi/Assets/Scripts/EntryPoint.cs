using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Models;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private UIView _uiView;
    [SerializeField] private GameObject _player;

    private MainController mainController;
    void Start()
    {
        var axisCustom = new Axis—ustom();
        mainController = new MainController(axisCustom, _uiView, _player);
    }

   
    void Update()
    {
        mainController.Update();
    }
}
