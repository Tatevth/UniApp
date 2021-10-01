using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniApp.Models;

namespace UniApp.Services
{
    class UniversityService
    {
        public void Show(List<StudentModel> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("____________________________");
                Console.WriteLine($"id = {students[i]._id} \t name = {students[i]._name} \tage = {students[i]._age} \t faculty = {students[i]._faculty}");
                Console.WriteLine("Student's teacher");
                if (students[i]._teacher != null)
                {
                    Console.WriteLine($"id = {students[i]._teacher._id} \t name = {students[i]._teacher._name}\tage = {students[i]._teacher._age}");
                }

            }
        }
        public void Show(List<TeacherModel> teachers)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("____________________________");
                Console.WriteLine($"id = {teachers[i]._id} \t name = {teachers[i]._name} \t age = {teachers[i]._age}");
                Console.WriteLine("Teacher's students");
                if (teachers[i]._students != null)
                {
                    for (int j = 0; j < teachers[i]._students.Count; j++)
                    {
                        Console.WriteLine($"\nid ={teachers[i]._students[j]._id} \t name ={teachers[i]._students[j]._name} \t age = {teachers[i]._students[j]._age} \t faculty ={teachers[i]._students[j]._faculty}");
                    }
                }
            }
        }
        public void Swap(List<StudentModel> students, List<TeacherModel> teacher)
        {
            for (int i = 0, j = 0; i < students.Count; i++, j++)
            {
                teacher[j]._students.Add(students[i]);
                students[i]._teacher = teacher[j];

                if (j == teacher.Count - 1)
                {
                    j = -1;
                }
            }
        }
       /* public List<TeacherModel> Swap(List<StudentModel> students, List<TeacherModel> teachers)
        {
            for (int i = 0, j = 0; i < students.Count; i++, j++)
            {
                teachers[j]._students.Add(students[i]);
                if (j == teachers.Count() - 1)
                    j = -1;
            }
​
            return teachers;
        }
​
        public List<StudentModel> Swap(List<TeacherModel> teachers, List<StudentModel> students)
        {
            for (int i = 0, j = 0; i < students.Count; i++, j++)
            {
                students[i]._teacher = teachers[j];
                if (j == teachers.Count() - 1)
                    j = -1;
            }
            return students;
        }*/

    }
}
