using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод количества студентов
            Console.Write("Введите количество студентов: ");
            int n = int.Parse(Console.ReadLine());

            //объявляем массив студентов размером в n
            Student[] students = new Student[n];

            //цикл с заполнением массива с клавиатуры
            for (int i = 0; i < n; i++)
            {
                //вводим все данные
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
            int count = 0; //счетчик который подсчитает сколько студентов с баллом выше 4

            for (int i = 0; i < n; i++) //цикл для проверки каждого студенкта 
            {
                double avg = students[i].Average(); //вызываем метод  для подсчета
                if (avg > 4) //ставим условие  если больше 4 то выводим информацию о студенте и увеличиваем счетчик
                {
                    Console.WriteLine($"{students[i].fullName}, группа {students[i].group}, средний балл: {avg:F2}");
                    count++;
                }
            }
            if (count == 0) //если счетчи равен 0 то выводим сообщение, это означает что таких студентов нет
            {
                Console.WriteLine("Нет студентов со средним баллом выше 4.");
            }
            else //если есть то выводи сообщение с счетчиком 
            {
                Console.WriteLine($"\nКоличество таких студентов: {count}");
            }
            Console.ReadLine();

        }
    }
}
