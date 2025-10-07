using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Csharp
{
    internal class GCdis : IDisposable
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }
        public GCdis(int _n1,int _n2)
        {
            num1 = _n1;
            num2 = _n2;
        }
        public void Dispose()
        {
            Console.WriteLine(num1 + num2);
            
        }
    }
}
