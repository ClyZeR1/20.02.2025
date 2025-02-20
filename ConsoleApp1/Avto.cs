using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avto
    {
        private string brand;
        private string color;
        private double skor;

        public double Skor
        {
            get { return skor; }
            set
            {
                if (value < 20) skor = 20;
                else if (skor > 120) skor = 120;
                else skor = value;
            }
        }

        public string Brand
        {
            get { return brand; }
            set
            { brand = value; }
        }

        public string Color
        {
            get { return color; }
            set
            { color = value; }
        }
        public Avto() { }
        public Avto(string brand)
        {
            this.brand = brand;
        }
        public Avto(string brand,string color, double skor) :this(color)
        {
            this.color = color;
            this.skor = skor;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Бренд: {Brand}\t Цвет: {Color}\t Скорость: {skor}");
        }
        public string Tostring()
        {
            return $"Бренд: {Brand}\t Цвет: {Color}\t Скорость: {skor}";
        }
    }
}
