using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабараторная работа №1\nВыполнил - Прокопчук Сергей");
            Console.WriteLine("Задание №1");

            Complex a = new Complex() { Real= 3, Imag = 0.5};
            Complex b = new Complex() { Real= 2, Imag = 0.8};
            a.Add(b);
            b.Subtract(a);
            a.Multiply(b);
            a.Divide(b);
            Console.WriteLine("a={0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b={0} + {1}i",b.Real, b.Imag);
            Console.WriteLine("a * b = {0} * {1}i", a.Real, a.Imag);
            Console.WriteLine("a / b = {0} / {1}i", a.Real, a.Imag);

            Console.WriteLine("Задание №2");
            List <Student> Students = new List<Student>
            {
                new Student("Alex",20,"Brown","Male",3.76),
                new Student("Mary",21,"Blond","Female",4.1),
                new Student("Jack",19,"Red","Male",4.9),
                new Student("Judy",23,"Blue","Female",4.1),
            };
            Students[0].Plus(Students);
        }
    }
}
