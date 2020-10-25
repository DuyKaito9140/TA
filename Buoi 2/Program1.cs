using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Phuong trinh: {0}x + {1} = 0", a, b);
            x = -b / a;
            Console.Write("x = " + x);
            Console.ReadLine();
        }
    }
}
