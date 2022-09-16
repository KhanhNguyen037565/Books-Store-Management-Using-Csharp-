using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticTrongCsharp
{
    class ThanhVienStatic
    {
        public static int num; // thanh vien static
        public void count()
        {
            num++;
        }
        // puong thuc static
        public static int getNum()
        {
            return num;
        }
      
    }
}
