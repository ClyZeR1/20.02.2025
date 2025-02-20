using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kadry kadry1 = new Kadry();
            kadry1.Fam = "Иванов";
            kadry1.Age = 25;
            kadry1.Dol = "Инженер";
            kadry1.Staj = 3;
            kadry1.ShowInfo();

            
            Kadry kadry2 = new Kadry("Петров", 40, "Менеджер", 15);
            kadry2.ShowInfo();

            
            Console.WriteLine("Фамилия :");
            string fam = Console.ReadLine();
            Console.WriteLine("Возраст :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Должность :");
            string dol = Console.ReadLine();
            Console.WriteLine("Стаж :");
            int staj = int.Parse(Console.ReadLine());

            Kadry kadry3 = new Kadry(fam, age, dol, staj);
            kadry3.ShowInfo();

            Console.ReadKey();
        }
    }
}
