using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac43.samostoyat
{
    public struct Student
    {
        public string fullName;
        public string group;
        public int informatics;
        public int physics;
        public int history;
        public double Average()
        {
            return (informatics + physics + history) / 3.0;
        }

    }
}
