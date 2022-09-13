using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemTraChuoiCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiem tra chuoi con trong C#:");
            Console.WriteLine("___________________________");

            string str = "Chuoi con trong c#";
            if (str.Contains("trong"))
            {
                Console.WriteLine("Tim thay chuoi con 'trong' ");
            }
            Console.ReadKey();
        }
    }
}
