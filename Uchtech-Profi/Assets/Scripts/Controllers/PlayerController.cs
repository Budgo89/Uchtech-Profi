
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    internal class PlayerController
    {
        private GameObject _player;
        private List<Coord> _coordList;
        private List<Vector3> _axisСustom;
        private List<Vector3> _coords;

        public PlayerController(GameObject player, CoordList coordList, AxisСustom axisСustom)
        {
            _player = player;
            _coordList = coordList.GetCoordList();
            _axisСustom = axisСustom.GetAxisСustom();
            _coords = new List<Vector3>();
        }

        public void Update()
        {
            MovePlayerBy(_coords);
        }

        private async void MovePlayerBy(List<Vector3> coords)
        {
            foreach (var to in coords)
            {
                await MoveTo(to);
            }
        }
        private async Task MoveTo(Vector3 to)
        {
            var _from = _player.transform.position;
            while (Vector3.SqrMagnitude(_from - to) > 0.001f)
            {
                Vector3 position = Vector3.Lerp(_from, to, 0.03f);
                _player.transform.position = position;
                await Task.Yield();
            }

        }
        public void GetСoordinates()
        {
            foreach (var coord in _coordList)
            {
                var rabX = Math.Sqrt(Math.Pow(_axisСustom[1].x - _axisСustom[0].x, 2) * 2 +
                                     Math.Pow(_axisСustom[1].y - _axisСustom[0].y, 2) * 2);
                var kX = coord.X / rabX;

                var XX = _axisСustom[0].x + (_axisСustom[1].x - _axisСustom[0].x) * kX;
                var XY = _axisСustom[0].y + (_axisСustom[1].y - _axisСustom[0].y) * kX;

                var vectorXAuxiliary = new Vector3((float)XX, (float)XY, 1);
                var axisX = _axisСustom[1] - _axisСustom[0];
                var normalAxisX = Vector3.Cross(axisX, vectorXAuxiliary);
                Debug.Log(normalAxisX);

                var rabY = Math.Sqrt(Math.Pow(_axisСustom[3].x - _axisСustom[2].x, 2) * 2 +
                                     Math.Pow(_axisСustom[3].y - _axisСustom[2].y, 2) * 2);
                var k = coord.X / rabY;

                var YX = _axisСustom[2].x + (_axisСustom[3].x - _axisСustom[2].x) * k;
                var YY = _axisСustom[2].y + (_axisСustom[3].y - _axisСustom[2].y) * k;

                var vectorYAuxiliary = new Vector3((float)YX, (float)YY, 1);
                var axisY = _axisСustom[1] - _axisСustom[0];
                var normalAxisY = Vector3.Cross(axisY, vectorYAuxiliary);
                Debug.Log(normalAxisY);

                float x1 = normalAxisX.x - normalAxisY.x;
                float y1 = normalAxisX.y - normalAxisY.y;


                _coords.Add(new Vector3(x1, y1, 0));
            }
           
            
        }

    }
}
