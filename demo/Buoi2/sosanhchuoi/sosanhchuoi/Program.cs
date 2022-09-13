using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosanhchuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("__________________");

            string str1 = "So sanh chuoi trong c#";
            string str2 = "So sanh chuoi trong Csharp";

            if(String.Compare(str1,str2) == 0)
            {
                Console.WriteLine(str1 + " va "+ str2 + "la giong nhau ");

            }
            else
            {
                Console.WriteLine(str1 + " va " + str2 + "la khac nhau ");
            }
            Console.ReadKey();
        }
    }
}
