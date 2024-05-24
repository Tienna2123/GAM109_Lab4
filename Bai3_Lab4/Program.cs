using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("1", "Tuan Dat", 20));
            list.Add(new Student("2", "Huy Duy", 12));
            list.Add(new Student("3", "Van Tiu", 14));
            list.Add(new Student("4", "Trong Cuong", 15));
            list.Add(new Student("5", "Anh Khoa", 18));
            // a
            var querySyntax = from student in list
                              where student.Age >= 12 && student.Age <= 20
                              select student;
            Console.WriteLine("cac hs co do tuoi tu 12 den 20 bang querysyntax:  ");
            foreach (var student in querySyntax)
            {
                Console.WriteLine($"ID: {student.ID} | Ten: {student.Name} | Tuoi: {student.Age}");

            }
            // b
            var methodSyntax = list.Where(student => student.Age >= 12 && student.Age <= 20);
            Console.WriteLine("cac hs co do tuoi tu 12 den 20 bang methodsyntax: ");
            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"ID: {student.ID} | Ten: {student.Name} | Tuoi: {student.Age}");
            }
        }
    }
}
