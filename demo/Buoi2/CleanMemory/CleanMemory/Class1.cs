using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMemory
{
    class Program
    {
        public static void Details()
        {
            // tao doi tuong Line bang constructor
            Line line = new Line();
            // thiet lap chieu dai cho duong
            line.setChieuDai(7.0);
            Console.WriteLine("Len ={0}", line.getChieuDai());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Destructor trong C#:");
            Console.WriteLine("_______________");
            Details();
            GC.Collect(); // don dep bo nho
            Console.ReadKey();
        }

    }
}
