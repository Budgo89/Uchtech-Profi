using Assets.Scripts.Models;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Controllers
{
    internal class UIController
    {
        private UIView _uiView;
        private CoordList _coordList;
        private Button _askButton;
        private Button _startButton;
        private PlayerController _playerController;
        private GameObject _player;
        private AxisСustom _axisСustom;

        public UIController(UIView uiView, CoordList coordList, GameObject player, AxisСustom axisСustom)
        {
            _uiView = uiView;
            _coordList = coordList;
            _player = player;
            _axisСustom = axisСustom;
            _askButton = _uiView.AskButton;
            _startButton = _uiView.StartButton;

            _askButton.onClick.AddListener(SetCoord);
            _startButton.onClick.AddListener(StartPlayer);
        }

        private void StartPlayer()
        {
            _playerController = new PlayerController(_player, _coordList, _axisСustom);
            _playerController.GetСoordinates();
        }

        private void Dispose()
        {
            _askButton.onClick.RemoveAllListeners();
            _startButton.onClick.RemoveAllListeners();
        }

        private void SetCoord()
        {
            var xString = _uiView.Axis1.text;
            var yString = _uiView.Axis2.text;
            float x = float.Parse(xString);
            float y = float.Parse(yString);

            _coordList.Add(x, y);
            Debug.Log("Добавлено");
        }

        public void Update()
        {
            if (_playerController != null)
                _playerController.Update();
        }
    }
}
