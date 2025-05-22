using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43.samostoyat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество студентов: ");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nСтудент №{i + 1}");
                Console.Write("ФИО: ");
                students[i].fullName = Console.ReadLine();

                Console.Write("Группа: ");
                students[i].group = Console.ReadLine();

                Console.Write("Оценка по информатике: ");
                students[i].informatics = int.Parse(Console.ReadLine());

                Console.Write("Оценка по физике: ");
                students[i].physics = int.Parse(Console.ReadLine());

                Console.Write("Оценка по истории: ");
                students[i].history = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nСтуденты со средним баллом больше 4:");
            int count= 0;

            for (int i = 0; i < n; i++)
            {
                double avg = students[i].Average();
                if (avg > 4)
                {
                    Console.WriteLine($"{students[i].fullName}, группа {students[i].group}, средний балл: {avg:F2}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Нет студентов со средним баллом выше 4.");
            }
            else
            {
                Console.WriteLine($"\nКоличество таких студентов: {count}");
            }
            Console.ReadLine();
        }
    }
}
