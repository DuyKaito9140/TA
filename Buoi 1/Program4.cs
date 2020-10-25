using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour, salary;
            int money;
            Console.Write("Nhap so gio lam viec: ");
            hour = double.Parse(Console.ReadLine());
            Console.Write("Nhap so tien lam theo gio: ");
            money = int.Parse(Console.ReadLine());

            salary = hour * money;
            Console.Write("Luong thang cua nhan vien la: " + salary);
            Console.ReadLine();
        }
    }
}
