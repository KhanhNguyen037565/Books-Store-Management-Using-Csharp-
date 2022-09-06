using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuyen doi kieu du lieu trong C#:");
            Console.WriteLine("_________________________________");
            double b = 5678.9876;
            int i;
            i = (int)b;
            Console.WriteLine("Gia tri cua i sau khi chuyen doi: "+ i);
            Console.ReadKey(); 
        }
    }
}
