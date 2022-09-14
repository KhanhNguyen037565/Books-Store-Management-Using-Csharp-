using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constrcutorClass
{
    class Line
    {
        private double chieu_dai;
        public Line()
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
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor trong C#");
            Console.WriteLine("______________________");
            //tao doi tuong Line bang constructor 
            Line line = new Line();

            // thiet lap chieu dai cho duong
            line.setChieuDai(6.0);
            Console.WriteLine("Chieu dai cua duong la: {0}", line.getChieuDai());
            Console.ReadKey();
        }
    }
}
