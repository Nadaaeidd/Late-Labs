using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Refree
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Refree(string _name, int _x, int _y)
        {
            Name = _name;
            X = _x;
            Y = _y;
        }
        public void OnBallMoved(Ball ball) {

            ball.BallFireed += MovreRefree;
        }
        public void MovreRefree(object sender, BallArgs e) {
            Console.WriteLine($"Refree {Name} moved to {e.X} - {e.Y}");
            X = e.X;
            Y = e.Y;
        }
    }
}
