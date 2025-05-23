using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43._2
{
    /// <summary>
    /// структура студент
    /// </summary>
    public struct Student
    {
        /// <summary>
        /// открытые поля фио группа информатика физика история
        /// </summary>
        public string fullName;
        public string group;
        public int informatics;
        public int physics;
        public int history;
        /// <summary>
        /// метод ср оценки выше 4 баллов
        /// </summary>
        /// <returns></returns>
        public double Average()
        {
            return (informatics + physics + history) / 3.0;
        }
    }
}
