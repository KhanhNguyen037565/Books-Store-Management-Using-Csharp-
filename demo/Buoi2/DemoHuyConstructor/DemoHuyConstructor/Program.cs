using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConstructor
{
    class Line
    {
        private double chieu_dai;
        public Line() // constructor k co tham so
        {
            Console.WriteLine("Doi tuong da duoc tao");
            
        }
        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }
        public double getChieuDai()
        {
            return chieu_dai;
        }
        ~Line()
        {
            Console.WriteLine("Doi tuong da bi xoa!!!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor trong C#:");
            Console.WriteLine("________________________");
            //tao doi tuong Line bang constructor
            Line line = new Line();
            Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());

            // thiet lap chieu dai cho duong
            line.setChieuDai(6.0);
            Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());
            Console.ReadKey();
        }
    }
}
