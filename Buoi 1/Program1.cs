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
            int a = 5;
            int b = 10;
            Console.WriteLine("So ban dau: ");
            Console.WriteLine("a = " + a + "\n" + "b = " + b);
            Console.WriteLine("-------------------");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Sau khi hoan vi: ");
            Console.WriteLine("a = " + a + "\n" + "b = " + b);
            Console.ReadLine();
        }
    }
}
