using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoTinhKeThua2
{
    class HinhChuNhat
    {
        protected double chieuDai;
        protected double chieuRong;
        public HinhChuNhat(double l, double v)
        {
            chieuDai = l;
            chieuRong = v;
        }
        public double tinhDienTich()
        {
            return chieuDai * chieuRong;
        }
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", chieuDai);
            Console.WriteLine("Chieu rong: {0}", chieuRong);
            Console.WriteLine("Dien tich: {0}", tinhDienTich());
        }
    }
    class ChiPhiXayDung : HinhChuNhat
    {
        private double cost;
        public ChiPhiXayDung(double l, double v) : base(l, v)
        {

        }
        public double tinhChiPhi()
        {
            double chiPhi;
            chiPhi = tinhDienTich() * 70;
            return chiPhi;
        }
        public void hienThiThongTin()
        {
            base.Display();
            Console.WriteLine("Chi phi: {0}", tinhChiPhi());
        }
    }
    public class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua trong C sharp:");
            Console.WriteLine("___________________________");
            // tao doi tuong chiphixaydung
            ChiPhiXayDung t = new ChiPhiXayDung(4.5, 7.5);
            t.hienThiThongTin();
            Console.ReadKey();
        }
    }
    
}
