using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour, meter, second;
            Console.Write("Nhap so giay: ");
            second = int.Parse(Console.ReadLine());

            hour = second / 3600;  second %= 3600;
            meter = second / 60;
            second %= 60;
            Console.WriteLine("{0} : {1} : {2}", hour, meter, second);
            Console.ReadLine();
        }
    }
}
