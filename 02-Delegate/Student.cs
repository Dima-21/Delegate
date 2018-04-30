using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Student
{
    class Student
    {
        public delegate int YourDelegate(int a);
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        List<int> _marks = new List<int>();

        public void SetMark(int mark)
        {
            if (mark > 0 && mark < 13)
                _marks.Add(mark);
        }

        public void SetMark(params int[] mark)
        {
            for (int i = 0; i < mark.Length; i++)
                if (mark[i] > 0 && mark[i] < 13)
                    _marks.Add(mark[i]);
        }

        public void ChitsAllMarksByFilter(YourDelegate d)
        {
            for (int i = 0; i < _marks.Count; i++)
                _marks[i] = d(_marks[i]);
        }

        public void Show()
        {
            Console.WriteLine($"{Name} {LastName} {Birthday.Day}.{Birthday.Month}.{Birthday.Year}");
            foreach (var item in _marks)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

