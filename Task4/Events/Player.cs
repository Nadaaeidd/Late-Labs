using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Player
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Player(string _name,int _x,int _y)
        {
            Name= _name;
            X= _x;
            Y= _y;
        }
        public void OnBallMoved(Ball ball)
        {
            ball.BallFireed += MovePlayer;
        }
        public void MovePlayer(object sender,BallArgs e)
        {
            Console.WriteLine($"Player {Name} has moved to {e.X},{e.Y} towards the ball");
            X = e.X;
            Y = e.Y;
        }

    }
}
