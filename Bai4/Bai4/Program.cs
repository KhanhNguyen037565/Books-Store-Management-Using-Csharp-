using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static public void DTTron()
        {
            const double PI = 3.14;
            double r;
            Console.Write("\t\tNhap r: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\tDien tich hinh tron la : {0}", PI*r*r);
        }
        static public void DTCN()
        {
            double cd, cr;
            Console.Write("\t\tNhap CD: ");
            cd = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\tNhap CR: ");
            cr = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\tDien tich hinh chu nhat la : {0}", cd*cr);
        }
        static public void DTTamGiac()
        {
            double h, d;
            Console.Write("\t\tNhap chieu cao: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\tNhap do dai day: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("\t\tDien tich hinh tam giac la : {0}", 0.5*h*d);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t\t_____________________________________________");
            Console.WriteLine("\t\t\t\t________                             ________");
            Console.WriteLine("\t\t\t\t_           0 - Dien tich hinh tron          ");
            Console.WriteLine("\t\t\t\t_         1 - Dien tich hinh chu nhat        ");
            Console.WriteLine("\t\t\t\t_         2 - Dien tich hinh tam giac        ");
            Console.WriteLine("\t\t\t\t_____                                   _____");
            Console.WriteLine("\t\t\t\t_____________________________________________");
            int n;
            Console.Write("\n\t\tNhap lua chon: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    DTTron();
                    Console.Beep();
                    Console.ReadKey();
                    break;
                case 1:
                    DTCN();
                    Console.Beep();
                    Console.ReadKey();
                    break;
                case 2:
                    DTTamGiac();
                    Console.Beep();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
