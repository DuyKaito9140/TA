using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, SoTo100, SoTo50, SoTo20, SoTo10, SoTo5, SoTo2, SoTo1;
            Console.Write("Nhap so tien: ");
            n = int.Parse(Console.ReadLine());

            SoTo100 = n / 100;  n %= 100;
            SoTo50  = n / 50;   n %= 50;
            SoTo20  = n / 20;   n %= 20;
            SoTo10  = n / 10;   n %= 10;
            SoTo5   = n / 5;    n %= 5;
            SoTo2   = n / 2;    n %= 2;
            SoTo1   = n;
            Console.WriteLine("So tien sau khi doi: ");
            Console.WriteLine("{0} to 100", SoTo100);
            Console.WriteLine("{0} to 50", SoTo50);
            Console.WriteLine("{0} to 20", SoTo20);
            Console.WriteLine("{0} to 10", SoTo10);
            Console.WriteLine("{0} to 5", SoTo5);
            Console.WriteLine("{0} to 2", SoTo2);
            Console.WriteLine("{0} to 1", SoTo1);
            Console.ReadLine();
        }
    }
}
