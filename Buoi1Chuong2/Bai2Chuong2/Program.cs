
using System.Text;

using System;
class Bai2{
    public static void Main(string[] args){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.OutputEncoding= Encoding.UTF8;
        string UserName;
        string PassWord;
        int count=0;
        do{
            Console.WriteLine("Nhập User: ");
            UserName= Console.ReadLine();
            Console.WriteLine("Nhập PassWord: ");
            PassWord= Console.ReadLine();
            count ++;
        }while(count !=3 && ( UserName !="Van Khanh" || PassWord !="02092002"));
        if(count <=3 && ( UserName =="Van Khanh" && PassWord =="02092002")){
            Console.WriteLine("Đăng nhập thành công!");
            Console.Beep();
        }
        else{
            Console.WriteLine("Tên đăng nhập hoặc mật khẩu sai.\nĐăng nhập thất bại");
            Console.Beep();
        }
    }
}