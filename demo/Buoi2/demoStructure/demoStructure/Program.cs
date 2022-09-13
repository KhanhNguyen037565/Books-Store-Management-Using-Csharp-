using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoStructure
{
    struct Book
    {
        private string ten_sach;
        private string tac_gia;
        private string the_loai;
        private int ma_sach;
        public void nhapGiaTri(string t, string a, string s, int id)
        {
            ten_sach = t;
            tac_gia = a;
            the_loai = s;
            ma_sach = id;
        }
        public void display()
        {
            Console.WriteLine("Tieu de: {0}", ten_sach);
            Console.WriteLine("Tac gia: {0}", tac_gia);
            Console.WriteLine("The loai: {0}", the_loai);
            Console.WriteLine("Ma sach: {0}", ma_sach);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Struct trong C#: ");
            Console.WriteLine("__________________________");
            Book book1 = new Book();
            Book book2 = new Book();

            // thong tin book1
            book1.nhapGiaTri("English Grammar is Use", "Raymond Murphy","English", 6495407);

            // thong tin book2
            book2.nhapGiaTri("Toan hoc cao cap", "Tran Van A", "Toan hoc", 10);

            //in thong tin book 1
            Console.WriteLine("In thong tin cuon sach 1:");
            book1.display();

            Console.WriteLine("______________________________");
            // tin thong tin cuon sach 2
            Console.WriteLine("In thong tin cuon sach 2:");
            book2.display();
            Console.ReadKey();


        }
    };
}
