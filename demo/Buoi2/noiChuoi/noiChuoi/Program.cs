using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noiChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Noi chuoi trong C#");
            Console.WriteLine("________");

            string[] starray = new string[]
            {
            "Hoc C# co ban va nang cao",
            "Chuong nay trinh bay ve chuoi trong C#",
            "Chung ta dang tim hieu ve noi chuoi trong C#",
            "Chuc cac em hoc tap tot"
            };
            string str = String.Join("\n", starray);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
