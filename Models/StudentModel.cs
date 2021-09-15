using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp.Models
{
    class StudentModel
    {
        public StudentModel(int id, string name, int age, string faculty)
        {
            _id = id;
            _name = name;
            _age = age;
            _faculty = faculty;
        }
        public int _id;
        public string _name;
        public int _age;
        public string _faculty;
        public TeacherModel _teacher;
    }
}
