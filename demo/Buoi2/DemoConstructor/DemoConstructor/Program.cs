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
        public Line(double len) // constructor co tham so
        {
            Console.WriteLine("Doi tuong da duoc tao, chiue dai = {0}", len);
            chieu_dai = len;
        }
        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }
        public double getChieuDai()
        {
            return chieu_dai;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor trong C#:");
            Console.WriteLine("________________________");
            //tao doi tuong Line bang constructor
            Line line = new Line(10.0);
            Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());

            // thiet lap chieu dai cho duong
            line.setChieuDai(6.0);
            Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());
            Console.ReadKey();
        }
    }
}
