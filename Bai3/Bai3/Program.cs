using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
      
        static public void ptb2(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem x={0}", -c / b);
                Console.Beep();
            }
            else if (a != 0)
            {
                double delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                    Console.Beep();
                }
                else if(delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1=x2={0}",-b/(2*a));
                    Console.Beep();
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: \nx1={0}\nx2={1}", ((-b + Math.Sqrt(delta)) / (2 * a)), ((-b - Math.Sqrt(delta)) / (2 * a)));
                    Console.Beep();
                }
            }
        }
        static void Main(string[] args)
        {
           
            double a, b, c;
            Console.WriteLine("Nhap a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Convert.ToDouble(Console.ReadLine());
            
            ptb2(a,b,c);
            
        }
    }
}
