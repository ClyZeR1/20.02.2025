using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto();
            avto.Brand = "Мерседес";
            avto.Color = "Зеленый";
            avto.Skor = 30;
            avto.ShowInfo();
            Console.WriteLine("Введите бренд:");
            string brend = Console.ReadLine();
            Console.WriteLine("Введите цвет:");
            string cvet = Console.ReadLine();
            int skor = int.Parse(Console.ReadLine());
            Avto avto1 = new Avto(brend,cvet,skor);
            Console.WriteLine($"{avto1.Tostring()}");
            Console.ReadKey();
        }
    }
}
