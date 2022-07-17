/*CODE: Nhập 3 chữ cái và hiển thị theo chiều ngược lại.*/
using System;
using System.Text;
namespace ChuCai
{
    using System;
    class ChuCai{
        
        public static int Main(string[] args){
            string[] str= new string[3];
            Console.OutputEncoding =Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i=0; i< str.Length; i++){
                Console.Write("Nhập chữ cái thứ {0}: ",i+1);
                str[i]= Console.ReadLine();
            }
            Console.WriteLine("Dãy chữ trước khi đảo ngược: ");
            for(int i=0; i< str.Length; i++){
                Console.WriteLine("str[{0}]= {1}",i,str[i]);
            }
            Array.Reverse(str);
            Console.WriteLine("Dãy chữ sau khi đảo ngược: ");
            for(int i=0; i< str.Length; i++){
                Console.WriteLine("str[{0}]= {1}",i,str[i]);
            }
            return 0;
        }
    }
}