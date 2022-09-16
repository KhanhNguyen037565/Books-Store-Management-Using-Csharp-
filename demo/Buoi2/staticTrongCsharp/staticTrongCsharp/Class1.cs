using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticTrongCsharp
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Phuong thuc static trong C#");
            Console.WriteLine("_______________________________");

            // tao cac doi tuong thanh vien static
            ThanhVienStatic s = new ThanhVienStatic();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("Gia tri cua num: {0}", ThanhVienStatic.getNum());
            Console.ReadKey();
        }
    }
}
