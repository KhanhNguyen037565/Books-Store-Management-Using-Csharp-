using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCsharp
{
    
     public class TestCsharp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Class trong C#: ");
            Console.WriteLine("________________");

            Box box1 = new Box();
            Box box2 = new Box();
            double the_tich;
            // thong tin cua Box 1
            box1.setChieuDai(6.0);
            box1.setChieuCao(5.0);
            box1.setChieuRong(9.0);

            // thong tin cua Box2
            box2.setChieuDai(16.0);
            box2.setChieuCao(15.0);
            box2.setChieuRong(19.0);

            // tinh va in the tich cua box 1
            the_tich = box1.tinhTheTich();
            Console.WriteLine("The tich cua box 1 la: {0}", the_tich);
            // tinh va in the tich cua box 2
            the_tich = box2.tinhTheTich();
            Console.WriteLine("The tich cua box 2 la: {0}", the_tich);
            Console.ReadKey();

        }
    }
}
