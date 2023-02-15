using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Student
    {
        private string Name;
        private int Age;
        private string HairColor;
        private string Sex;
        private double Mark;
        public Student(string name, int age, string haircolor, string sex,double mark)
        {
            Age = age;
            Name = name;
            HairColor = haircolor;
            Sex = sex;
            Mark = mark;
        }
        public void Plus(List <Student> array)
        {
            int SumAge = 0;
            int CountMale = 0;
            int CountFemale = 0;
            int All = array.Count;
            double SumMark = 0;
            for (int i = 0;i< All; i++)
            {
                Console.WriteLine($"Имя: {array[i].Name}, Возраст: {array[i].Age}, Пол: {array[i].Sex}, Цвет волос: {array[i].HairColor}, Средний балл {array[i].Mark}");
                SumAge += array[i].Age;
                SumMark += array[i].Mark;
                if (array[i].Sex == "Male")
                {
                    CountMale++;
                }
                else
                {
                    CountFemale++;
                }
            }
            SumMark=SumMark/All;
            Console.WriteLine($"Итого:\nВсего людей: {All}\nСуммарный возраст {SumAge}\nМужчин: {CountMale}\nЖенщин: {CountFemale} \nСредний балл:{SumMark}");
        }
    }
}
