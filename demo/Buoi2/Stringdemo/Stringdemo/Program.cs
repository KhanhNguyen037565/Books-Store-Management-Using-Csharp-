using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cac cach tao chuoi trong C#");
            Console.WriteLine("_________________________");

            // su dung phep gan chuoi va toan tu noi chuoi
            string fname, lname;
            lname = "Nguyen Thi Van";
            fname = "Khanh";

            string fullname = lname + " " + fname;
            Console.WriteLine("Ho va ten: {0}", fullname);

            // su dung constructor cua lop string
            char[] letters = { 'H','E','L', 'L', 'O' };
            string greeting = new string(letters);
            Console.WriteLine("\nLoi chao bang tieng anh: {0}", greeting);

            // tu cac phuong thuc ma tra ve mot chuoi
            string[] sarray = { "C#", "xin", "chao", "cac", "ban" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Thong diep: {0}", message);

            // dinh dang phuong thuc de chuyen doi mot gia tri
            DateTime waiting = new DateTime(2020, 8, 1, 17, 58, 1);
            string chat = String.Format("Thong diep duoc gui luc {0:t} ngay {0:D}", waiting);
            Console.WriteLine("thong diep: {0}", chat);
            Console.ReadKey();
        }
    }
}
