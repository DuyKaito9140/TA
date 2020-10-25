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
            int code, number;
            double price = 0.00;
            string name = "";
            double cost;           
            Console.Write("Nhap ma san pham: ");
            code = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong san pham: ");
            number = int.Parse(Console.ReadLine());

            switch (code) 
            {
                case 1: price = 4.00; name = "Cochorro	Quente"; break;
                case 2: price = 4.50; name = "X-Salada	"; break;
                case 3: price = 5.00; name = "X-Bacon"; break;
                case 4: price = 2.00; name = "Torrada simples"; break;
                case 5: price = 1.00; name = "Refrigerante"; break;
                default: 
                    Console.WriteLine("Ma san pham khong ton tai !"); number = 0; break;
            }
            cost = number * price;
            Console.WriteLine("Ban mua " + name + " so luong " + number + " gia " + price + "R$");
            Console.WriteLine("So tien phai tra: " + cost + "R$");
            Console.ReadLine();
        }
    }
}
