using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string passWord;
            int count = 0;
            do
            {
                Console.WriteLine("Nhap User: ");
                userName = Console.ReadLine();
                Console.WriteLine("Nhap password: ");
                passWord = Console.ReadLine();
                count++;

            } while (count != 3 && (userName != "Van Khanh" || passWord != "02092002"));
            if(count <= 3 && (userName == "Van Khanh" && passWord == "02092002"))
            {
                Console.WriteLine("Dang nhap thanh cong!");
                Console.Beep();

            }
            else
            {
                Console.WriteLine("Ten dang nhap hoac mat khau sai!\nDang nhap that bai!");
                Console.Beep();
            }
        }
    }
}
