using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[3];
            for(int i=0; i<str.Length; i++)
            {
                Console.WriteLine("Nhap chu cai thu {0}", i + 1);
                str[i] = Console.ReadLine();            
            }
            Console.WriteLine("Day truoc khi dao nguoc: ");
            for(int i=0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            Array.Reverse(str);
            Console.WriteLine("Day sau khi dao nguoc: ");
            for(int i=0;i< str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            
        }
    }
}
