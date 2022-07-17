using System.Text;
namespace Chuong2{
    using System;
    class Bai3Chuong2{ // ax^2 +bx +c =0
        //double a,b,c;
        
        static public void Nhap(double a,double b,double c){
            if(a ==0){
                Console.WriteLine("Phương trình có nghiệm x= {0}", -c/b);
                Console.Beep();
            }
           
            else if(a !=0){
                double delta = b*b - 4*a*c;
                if(delta < 0){
                    Console.WriteLine("Phương trình Vô nghiệm");
                    Console.Beep();
                }else if(delta ==0 ){
                    Console.WriteLine("Phương trình có nghiệm kép x1= x2 ={0}", -b/(2*a));
                    Console.Beep();
                }else{
                    Console.WriteLine("Phương trình có nghiệm x1= {0} \nx2 ={1}", ((-b+ Math.Sqrt(delta))/(2*a)) , ((-b- Math.Sqrt(delta))/(2*a)));
                    Console.Beep();
                }
            }
    }
        
            
        public static void Main(string[] args){
            double a;
            double b,c;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap a: ");
            string n=Console.ReadLine();
            //a = Convert.ToInt32(n);
            a=double.Parse(n);
            Console.Write("Nhap b: ");
            string l=Console.ReadLine();
            b=double.Parse(l);
            Console.Write("Nhap c: ");
            string d=Console.ReadLine();
            c=double.Parse(d);
            Nhap(a,b,c);
        }
    }
}
