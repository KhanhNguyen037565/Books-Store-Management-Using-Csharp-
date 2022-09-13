using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privite
{
    class Rectangle
    {
        //cac bien thanh vien
        public double length;
        public double width;

        //cac phuong thuc
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Chiue dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C# ");
            Console.WriteLine("______________________________");

            // tao doi tuong rectangle
            Rectangle r = new Rectangle();
            //thiet lap cac thuoc tinh

            r.length = 4.5;
            r.width = 3.5;
            // goi phuong thuc
            r.Display();
            Console.ReadKey();
        }
    }
}
