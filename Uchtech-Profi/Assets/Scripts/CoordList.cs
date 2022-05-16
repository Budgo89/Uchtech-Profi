using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Models;

namespace Assets.Scripts
{
    internal class CoordList
    {
        private List<Coord> _coordList;

        public CoordList()
        {
            _coordList = new List<Coord>();
        }

        public void Add(float x, float y)
        {
            _coordList.Add(new Coord(x,y));
        }

        public List<Coord> GetCoordList()
        {
            return _coordList;
        }
    }
}
