using System.Collections.Generic;
using UnityEngine.TerrainUtils;

namespace Assets.Scripts.Models
{
    internal class Coord
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Coord(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
