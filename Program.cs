using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA, intB, intC;
            double x1, x2, delta;
            Console.WriteLine("*******Chuong trinh Giai Phuong Trinh Bac 2*******");
            Console.WriteLine("***************ax^2 + bx + c = 0***************");
            Console.Write("Nhap a: ");
            intA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            intB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            intC = Convert.ToInt32(Console.ReadLine());

            if (intA == 0)
            {
                if (intB == 0)
                {
                    if (intC == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else 
                { 
                x1 = (double)-intC / intB;
                Console.WriteLine("Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
           
            }
            else
            {
                delta = Math.Pow(intB, 2) - 4 * intA * intC;
                if (delta<0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta==0) 
                {
                    x1 = x2 = -intB / (2 * intA);
                    Console.WriteLine("Phuong trinh co nghiem kep 1x = 2x = {0}", x1);
                }
                else
                {
                    x1 = (-intB + Math.Sqrt(delta)) / (2 * intA);
                    x2 = (-intB - Math.Sqrt(delta)) / (2 * intA);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet: X1 = {0} X2 = {1}", x1, x2);
                }
            }
            Console.ReadKey();
        }
    }
}
