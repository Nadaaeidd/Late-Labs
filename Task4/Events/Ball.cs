using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Ball
    {
        public string Name { get; set; }
        public event EventHandler<BallArgs> BallFireed;
        public Ball(string _name)
        {
            Name= _name;
        }
        public void BallMovedTo(int x,int y)
        {
            Console.WriteLine($"{Name} Moved to {x},{y}");
            BallFireed?.Invoke(this, new BallArgs(x,y));
        }
        public override string ToString()
        {
            return $"Name : {Name}";
        }
    }
}
