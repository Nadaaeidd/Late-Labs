using System.Linq.Expressions;

namespace Task5Csharp
{
    internal class Program
    {
        public static void myfun(int x,int y)
        {
             try
             {
                Console.WriteLine(x / y);
             }
            catch(FormatException)
            {
                Console.WriteLine("invalid format ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("invalid number ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
        static void Main(string[] args)
        {
            int x;
            int y;
           Console.WriteLine("Please enter number 1 :");
           bool z=int.TryParse(Console.ReadLine(),out x);
            Console.WriteLine("Please enter number 2 :");
            bool f=int.TryParse(Console.ReadLine(),out y);

            if (z==true && f==true) 
            {
                myfun(x, y);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            int[] arr = { 1, 2, 3 };
            try
            {
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }

            using (GCdis cdis = new GCdis(10, 20))
            {
                
            }

        }
    }
}
