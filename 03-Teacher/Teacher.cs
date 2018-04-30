using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Teacher
{
    class Teacher
    {
        public delegate bool DELEGATE(Student s);
        List<Student> _students = new List<Student>();
        public void AddStudent(Student s)
        {
            _students.Add(s);
        }
       

        public void RemoveStudent(Student s)
        {
            try
            {
                _students.Remove(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! Student not found!");
            }
        }
        public void SendAllStudentsMark(params int[] mark)
        {
            foreach (var item in _students)
                item.SetMark(mark);
        }

        public void SetMark(string lname, params int[] mark)
        {
            foreach (var item in _students)
                if(item.LastName == lname)
                    item.SetMark(mark);
        }

        public Student[] GetStudentsByFilter(DELEGATE d)
        {
            List<Student> filter = new List<Student>();
            foreach (var item in _students)
                if (d(item))
                    filter.Add(item);
            return filter.ToArray();
        }
        public void Show(Student[] s)
        {
            foreach (var item in s)
            {
                item.Show();
            }
        }
    }
}
