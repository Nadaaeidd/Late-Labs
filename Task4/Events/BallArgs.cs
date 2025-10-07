using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class BallArgs:EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public BallArgs(int _x,int _y)
        {
            X= _x;
            Y= _y;
        }
    }
}
