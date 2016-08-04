using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeBowl.Engine
{
    public class Point
    {

        public Point(int v1, int v2)
        {
            x = v1;
            y = v2;
        }

        public int x { get; set; }
        public int y { get; set; }

        public int GetSquaredDistance(Point p)
        {
            return ((p.x - x) * (p.x - x)) + ((p.y - y) * (p.y - y));
        }

        
    }
}
