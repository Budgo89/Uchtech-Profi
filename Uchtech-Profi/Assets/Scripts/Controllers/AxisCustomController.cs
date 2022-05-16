using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    internal class AxisCustomController
    {
        private AxisСustom _axisСustom;
        public AxisCustomController(AxisСustom axisСustoms)
        {
            _axisСustom = axisСustoms;
        }

        public void SetVector()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && _axisСustom.flag == true)
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                _axisСustom.Add(ray.direction);
                Debug.Log(ray.direction);
            }

            if (Input.GetKeyDown(KeyCode.Mouse1) && _axisСustom.flag == false)
            {
                Debug.Log("Ось 1 ");
                Debug.Log(_axisСustom.GetAxisСustom()[0]);
                Debug.Log(_axisСustom.GetAxisСustom()[1]);
                Debug.Log("Ось 2 ");
                Debug.Log(_axisСustom.GetAxisСustom()[2]);
                Debug.Log(_axisСustom.GetAxisСustom()[3]);
            }
        }
    }
}
