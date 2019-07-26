using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 碰撞模拟
{
    class Ball
    {
        public Point CircleCenter { get; set; }
        public int Radius { get; set; }

        public int Mass { get; set; }

        public Ball(Point center,int radius )
        {
            this.CircleCenter = center;
            this.Radius = radius;
        }

    }
   
}
