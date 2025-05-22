using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43._1prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b;
            b.Name = "BookName";
            b.Year = 2000;
            b.Autor = "BookAutor";

            Console.WriteLine("НАзвание: "+b.Name);
            Console.WriteLine("ГОд: " + b.Year);
            Console.WriteLine("АВтор: " + b.Autor);
            Console.Read();
        }
    }
}
