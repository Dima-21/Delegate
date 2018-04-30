using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Teacher
{
    struct Filters
    {
        public static bool Filter1(Student s)
        {
            if (s.Average() > 7)
                return true;
            return false;
        }
        public static bool Filter2(Student s)
        {
            if ((s.Birthday.Month == 4 && s.Birthday.Day == 1) || s.CountMarks(10) > 2)
                return true;
            return false;
        }
        public static bool Filter3(Student s)
        {
            if (s.Average() < 5 && s.CountMarks(11) == 0)
                return true;
            return false;
        }
    }
}
