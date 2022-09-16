using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMemory
{
    class Line
    {
        private double chieuDai;
        public Line()
        {

        }
        public void setChieuDai(double len)
        {
            chieuDai = len;
        }
        public double getChieuDai()
        {
            return chieuDai;
        }
        ~Line()
        {

        }
        

    }
}
