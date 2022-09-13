using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraydemo
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            /*
            //cach khai bao va khoi tao mang
            // cach 1
            double[] balance = new double[10];
            balance[0] = 4500.0;
            // cach 2
            double[] balance2 = { 2340.0, 4523.69, 3421.0 };
            // cach 3
            int[] marks = new int[5] { 99, 92, 98, 97, 96 };
            // cach 4
            int[] score = marks;
            */
            Console.WriteLine("Mang trong C#:");
            Console.WriteLine("_________________");

            int[] n = new int[10];
            int i, j;
            // khoi tao cac phan tu cua mang n
            for(i=0; i< 10; i++)
            {
                n[i] = i + 1;
            }

            // hien thi cac phan tu trong mang n
            for(j=0; j<10; j++)
            {
                Console.WriteLine("Phan tu thu {0} la: {1}", j+1, n[j]);
            }
            Console.ReadKey();

        }
    }
}
