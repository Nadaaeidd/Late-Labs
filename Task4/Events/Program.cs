namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball   ball    = new Ball("red ball");
            Player player  = new Player("Mohamed",10,30);
            Player player2 = new Player("Mohamed",20,30);
            Player player3 = new Player("Mohamed",40,30);
            Refree refree = new("Me", 50, 60);

         
            player3.OnBallMoved(ball);
            refree.OnBallMoved(ball);

        
            ball.BallMovedTo(70, 80);

        }
    }
}
