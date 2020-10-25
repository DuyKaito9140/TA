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
            Console.Write("Nhap ban kinh r: ");
            double r = double.Parse(Console.ReadLine());

            double S = Math.PI * r * r;
            Console.WriteLine("Dien tich hinh tron la: " + S);
            Console.ReadLine();
        }
    }
}
