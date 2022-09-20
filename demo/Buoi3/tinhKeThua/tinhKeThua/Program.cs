using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {
        protected int chieuRong;
        protected int chieuCao;
        public void setChieuRong(int w)
        {
            chieuRong = w;
        }
        public void setChieuCao(int v)
        {
            chieuCao = v;
        }
    }
    class Rectangle : Shape
    {
        public int tinhDienTich()
        {
            return (chieuRong*chieuCao);
        }
    }
public class TestCsharp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua trong C#:");
            Console.WriteLine("______________________");

            //tao doi tuong hinhchu nhat
            Rectangle hcn = new Rectangle();
            hcn.setChieuRong(5);
            hcn.setChieuCao(7);

            // in dien tich cua doi tuong
            Console.WriteLine("Dien tich cua hinh chu nhat: {0}", hcn.tinhDienTich());
            Console.ReadKey();
        }
    }
}
