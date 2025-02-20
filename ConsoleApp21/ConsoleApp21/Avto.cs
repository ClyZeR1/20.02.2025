using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Avto
    {
        private string model;
        private string color;
        private int skor;

        public string Model
        {
            get { return string.IsNullOrWhiteSpace(model) ? "неизвестный" : model; }
            set { model = value; }
        }

        public string Color
        {
            get { return string.IsNullOrWhiteSpace(color) ? "неизвестный" : color; }
            set { color = value; }
        }

        public int Skor
        {
            get { return skor; }
            set
            {
                if (value < 60) skor = 60;
                else if (value > 150) skor = 150;
                else skor = value;
            }
        }

        public Avto() { }

        public Avto(string model, string color, int skor)
        {
            Model = model;
            Color = color;
            Skor = skor;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {Model}\tЦвет: {Color}\tСкорость: {Skor} км/ч");
        }

        public override string ToString()
        {
            return $"Модель: {Model}\tЦвет: {Color}\tСкорость: {Skor} км/ч";
        }
    }
}
