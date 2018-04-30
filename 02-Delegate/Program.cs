using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Student
{
    class Program
    {
        static int Enhance(int mark)
        {
            if (mark < 5)
                return mark += 2;
            return mark;
        }

        static int Reduce(int mark)
        {
            if (mark > 9)
                return --mark;
            return mark;
        }
        static void Main(string[] args)
        {
            Student s = new Student { Name = "Vova", LastName = "Vovanovich", Birthday = new DateTime(2000, 9, 9) };
            s.SetMark(8, 4, 9, 1, 3, 10, 11, 3, 6, 12);
            s.Show();
            s.ChitsAllMarksByFilter(Enhance);
            s.Show();
            s.ChitsAllMarksByFilter(Reduce);
            s.Show();
        }
    }
}
