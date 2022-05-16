using Assets.Scripts;
using Assets.Scripts.Controllers;
using Assets.Scripts.Models;
using UnityEngine;

internal class MainController
{
    private Axis—ustom _axisCustom;
    private AxisCustomController _axisCustomController;
    private UIView _uiView;
    private readonly UIController _uiController;
    private readonly CoordList _coordList;
    private GameObject _player;

    public MainController(Axis—ustom axisCustoms, UIView uiView, GameObject player)
    {
        _axisCustom = axisCustoms;
        _uiView = uiView;
        _player = player;

        _coordList = new CoordList();

        _axisCustomController = new AxisCustomController(_axisCustom);

        _uiController = new UIController(_uiView, _coordList, _player, _axisCustom);
    }

    public void Update()
    {
        _axisCustomController.SetVector();
        _uiController.Update();
    }
}
