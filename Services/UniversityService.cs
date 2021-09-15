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
                Console.WriteLine($"id-{students[i]._id}\nname-{students[i]._name}\nage-{students[i]._age}\nfaculty-{students[i]._faculty}\n");
                Console.WriteLine("Student's teacher");
                if (students[i]._teacher!=null)
                {
                    Console.WriteLine($"id-{students[i]._teacher._id}\nname-{students[i]._teacher._name}\nage-{students[i]._teacher._age}\n");
                }

            }
        }
        public void Show(List<TeacherModel> teachers)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                Console.WriteLine("____________________________");
                Console.WriteLine($"id-{teachers[i]._id}\nname-{teachers[i]._name}\nage-{teachers[i]._age}\n");
                Console.WriteLine("Teacher's students");
                if (teachers[i]._students != null)
                {
                    for (int j = 0; j < teachers[i]._students.Count; j++)
                    {
                        Console.WriteLine($"_id-{teachers[i]._students[j]._id} _name-{teachers[i]._students[j]._name} _age-{teachers[i]._students[j]._age} _faculty-{teachers[i]._students[j]._faculty}");
                    }
                }
            }
        }

    }
}
