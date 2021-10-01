using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniApp.Models;
using UniApp.Services;

namespace UniApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vle");
            List<StudentModel> students = new List<StudentModel>();
            List<TeacherModel> teachers = new List<TeacherModel>();

            StudentService studentService = new StudentService();
            for (int i = 0; i < 2000; i++)
            {
                studentService.Add(new StudentModel(i, $"n{i}", i + 16, $"f{i}"));
            }
            TeacherService teacherService = new TeacherService();
            for (int j = 0; j < 3; j++)
            {
                teacherService.Add(new TeacherModel(j, $"n{j}", j + 24));
            }
            students = studentService.GetAll();
            teachers = teacherService.GetAll();

            UniversityService university = new UniversityService();
            university.Swap(students, teachers);
           //university.Swap(teachers, students);

            university.Show(students);
            university.Show(teachers);

            Console.ReadKey();
        }
    }
}
