using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MIAPR1
{


    internal class Point
    {
        public int x;
        public int y;
        public Color color;
        public double distance;
        public int claster;
        public bool isCenter;
        public Point(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
    }
}
