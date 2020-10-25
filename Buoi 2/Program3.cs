using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;  
            int i = 0;
            do
            {
                if (i == 0)
                    Console.Write("Nhap x: ");
                else
                    Console.Write("Nhap lai x (0 <= x <= 100): ");
                x = double.Parse(Console.ReadLine());
                i++;
            }
            while (x < 0 || x > 100);
            //kiem tra
            if (x <= 25)
                Console.WriteLine("x = {0} thuoc [0,25]", x);
            else if (x <= 50)
                Console.WriteLine("x = {0} thuoc (25,50]", x);
            else if (x <= 75)
                Console.WriteLine("x = {0} thuoc (50,75]", x);
            else
                Console.WriteLine("x = {0} thuoc (75,100]", x);

            Console.ReadLine();
        }
    }
}
