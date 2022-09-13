using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    
        class Box
        {
            public double chieu_dai;
            public double chieu_rong;
            public double chieu_cao;
        public void setChieuDai(double len)
        {
            chieu_dai = len;
        }
        public void setChieuCao(double hei)
        {
            chieu_dai = hei;
        }
        public void setChieuRong(double bre)
        {
            chieu_dai = bre;
        }
        public double tinhTheTich()
        {
            return chieu_dai * chieu_dai * chieu_cao;
        }
    }
    
}
