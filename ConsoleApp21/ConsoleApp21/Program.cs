using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto avto = new Avto();
            avto.Model = "Мерседес";
            avto.Color = "Зеленый";
            avto.Skor = 30;
            avto.ShowInfo();

            Console.WriteLine("Введите модель:");
            string model = Console.ReadLine();
            Console.WriteLine("Введите цвет:");
            string color = Console.ReadLine();
            Console.WriteLine("Введите скорость:");
            int skor = int.Parse(Console.ReadLine());

            Avto avto1 = new Avto(model, color, skor);
            Console.WriteLine(avto1.ToString());

            Console.ReadKey();
        }
    }
}