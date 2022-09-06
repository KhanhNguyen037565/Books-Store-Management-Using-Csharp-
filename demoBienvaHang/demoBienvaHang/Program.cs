using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoBienvaHang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Khai bao va khoi tao bien trong C#:");
            Console.WriteLine("___________________________________");

            //khai bao bien
            short a;
            int b;
            double c;

            //khoi tao bien
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
           
            Console.WriteLine("Hang so trong C#: ");
            Console.WriteLine("_____________________");

            // khai bao hang so pi
            const double pi = 3.12159;
            double r;
            Console.Write("Nhap ban kinh: ");
            r = Convert.ToDouble(Console.ReadLine());
            double dienTich = pi * r * r;
            Console.WriteLine("\nBan kinh: {0}, Dien tich: {1}", r, dienTich);
            Console.ReadKey();
        }
    }
}
