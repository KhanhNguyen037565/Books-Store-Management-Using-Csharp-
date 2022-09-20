using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Shape
    {
        protected int chieuRong;
        protected int chieuDai;
        public void setChieuRong(int r)
        {
            chieuRong = r;
        }
        public void setChieuDai(int d)
        {
            chieuDai = d;
        }
        public interface chiPhiSon
        {
            int tinhChiPhi(int dienTich);
        }
    class HinhChuNhat : Shape, chiPhiSon
        {
            public int tinhDienTich()
            {
                return (chieuDai * chieuRong);
            }
            public int tinhChiPhi(int dienTich)
            {
                return dienTich * 70;
            }
        }
    public class TestCsharp
        {
            public static void Main(string[] args)
            {
                HinhChuNhat hcn = new HinhChuNhat();
                int dienTich;
                hcn.setChieuRong(5);
                hcn.setChieuDai(7);
                dienTich = hcn.tinhDienTich();

                // in dien tich va chi phi
                Console.WriteLine("Tong dien tich: {0}", hcn.tinhDienTich());
                Console.WriteLine("Tong chi phi son: {0}", hcn.tinhChiPhi(dienTich));
                Console.ReadKey();
            }
        }
    }
}
