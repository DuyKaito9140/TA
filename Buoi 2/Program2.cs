using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;          
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = double.Parse(Console.ReadLine());
            double max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.ReadLine();
        }
    }
}
