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
            double x, y;
            Console.Write("Nhap toa do x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
                Console.WriteLine("Diem nam o goc toa do");
            else if (x == 0 && y != 0)
                Console.WriteLine("Diem nam o truc Oy");
            else if (x != 0 && y == 0)
                Console.WriteLine("Diem nam o truc Ox");
            else if (x > 0 && y > 0)
                Console.WriteLine("Diem do thuoc Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Diem do thuoc Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Diem do thuoc Q3");
            else
                Console.WriteLine("Diem do thuoc Q4");

            Console.ReadLine();
        }
    }
}
