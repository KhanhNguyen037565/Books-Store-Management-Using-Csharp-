using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraydemo2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Mang trong C#:");
            Console.WriteLine("____________");
            int[] n = new int[10];

            // khoi tao cac phan tu trong mang n
            for(int i=0; i<10; i++)
            {
                n[i] = i + 100;
            }

            // hien thi cac phan tu trong mang n
            foreach(int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Phan tu {0} la {1}", i+1, j);
            }
            Console.ReadKey();
        }
    }
}
