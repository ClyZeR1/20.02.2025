using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Kadry
    {
    private string fam;
    private int age;
    private string dol;
    private int staj;

    public string Fam
    {
        get { return string.IsNullOrWhiteSpace(fam) ? "неизвестный" : fam; }
        set { fam = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 16) age = 16;
            else if (value > 60) age = 60;
            else age = value;
        }
    }

    public string Dol
    {
        get { return string.IsNullOrWhiteSpace(dol) ? "неизвестная должность" : dol; }
        set { dol = value; }
    }

    public int Staj
    {
        get { return staj; }
        set
        {
            if (value < 0) staj = 0;
            else if (value > 45) staj = 45;
            else staj = value;
        }
    }

    // Конструктор без параметров
    public Kadry() { }

    // Конструктор с параметрами
    public Kadry(string fam, int age, string dol, int staj)
    {
        Fam = fam;
        Age = age;
        Dol = dol;
        Staj = staj;
    }

    // Метод для вывода информации об объекте
    public void ShowInfo()
    {
        Console.WriteLine($"Фамилия: {Fam}\tВозраст: {Age}\tДолжность: {Dol}\tСтаж: {Staj} лет");
    }
}
}