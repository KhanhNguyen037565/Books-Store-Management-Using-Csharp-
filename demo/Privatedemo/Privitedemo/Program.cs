using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privatedemo
{
    class rectangle
    {
        private double length;
        private double width;

        // cac phuong thuc
        public void Acceptdetails()
        {
            Console.WriteLine("Nhap chieu dai: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
        static void Main(string[] args)
        {
            // tao doi tuong
            rectangle r = new rectangle();
            // thiet lap cac thuoc tinh
            //r.length = 4.5;
            //r.width = 3.5;
            // goi phuong thuc
            r.Acceptdetails();
            r.Display();
            Console.ReadKey();
        }
    }
}
