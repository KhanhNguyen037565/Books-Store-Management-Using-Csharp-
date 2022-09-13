using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClass
{
    class Box
    {
        public double chieu_dai;
        public double chieu_rong;
        public double chieu_cao;
    }
    public class TestCsharp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Class trong C#: ");
            Console.WriteLine("________________");

            Box box1 = new Box();
            Box box2 = new Box();
            double the_tich = 0.0;
            // thong tin cua Box 1
            box1.chieu_cao = 5.0;
            box1.chieu_dai = 6.0;
            box1.chieu_rong = 7.0;

            // thong tin cua Box2
            box2.chieu_cao = 10.0;
            box2.chieu_dai = 16.0;
            box2.chieu_rong = 17.0;

            // tinh va in the tich cua box 1
            the_tich = box1.chieu_cao * box1.chieu_dai * box1.chieu_rong;
            Console.WriteLine("The tich cua box 1 la: {0}", the_tich);
            // tinh va in the tich cua box 2
            the_tich = box2.chieu_cao * box2.chieu_dai * box2.chieu_rong;
            Console.WriteLine("The tich cua box 2 la: {0}", the_tich);
            Console.ReadKey();

        }
    }
}
