using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layChuoiConTrongCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lay chuoi con trong C#");
            Console.WriteLine("_________________________");

            string str = "Lay chuoi con trong C#";
            Console.WriteLine("Chuoi ban dau: " + str);
            string substr = str.Substring(10);
            Console.WriteLine("Chuoi con: " + substr);
            Console.ReadKey();
        }
    }
}
