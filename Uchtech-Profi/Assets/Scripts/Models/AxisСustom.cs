using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Models
{
    internal class AxisСustom
    {

        public Vector3 Position { get; set; }
        public bool flag = true;

        private List<Vector3> axus;

        public AxisСustom()
        {
            axus = new List<Vector3>();
        }

        public void Add(Vector3 vector3)
        {

            if (flag)
            {
                axus.Add(vector3);
            }
            if (axus.Count >= 4)
            {
                flag = false;
            }
        }

        public List<Vector3> GetAxisСustom()
        {
            return axus;
        }
    }
}
