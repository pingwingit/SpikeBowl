using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public int GetSquaredDistance(Point p)
        {
            return ((p.x - x) * (p.x - x)) + ((p.y - y) * (p.y - y));
        }
    }
}
