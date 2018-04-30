using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Teacher
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.AddStudent(new Student { Name = "Vova", LastName = "Vovanov", Birthday = new DateTime(1998, 9, 9) });
            teacher.AddStudent(new Student { Name = "Taras", LastName = "Tarasov", Birthday = new DateTime(1995, 1, 22) });
            teacher.AddStudent(new Student { Name = "Bogdan", LastName = "Bogdanov", Birthday = new DateTime(1996, 4, 1) });
            teacher.AddStudent(new Student { Name = "Kolya", LastName = "Kolyov", Birthday = new DateTime(1994, 3, 28) });

            teacher.SendAllStudentsMark(6);
            teacher.SetMark("Vovanov", 4, 2, 10, 2);
            teacher.SetMark("Tarasov", 9, 8, 12);
            teacher.SetMark("Kolyov", 9, 11, 12, 11);

            Student[] student1 = teacher.GetStudentsByFilter(Filters.Filter1);
            Student[] student2 = teacher.GetStudentsByFilter(Filters.Filter2);
            Student[] student3 = teacher.GetStudentsByFilter(Filters.Filter3);

            Console.WriteLine("Студенты, которые имеют средний бал выше 7");
            teacher.Show(student1);
            Console.WriteLine("******************************************");

            Console.WriteLine("Студенты, у которых больше 2-х оценок больше 10 или они народились 1 апреля");
            teacher.Show(student2);
            Console.WriteLine("******************************************");

            Console.WriteLine("Студенты, у которых средний бал меньше 5 и при этом нету ни одной 12-ки");
            teacher.Show(student3);
        }
    }
}
