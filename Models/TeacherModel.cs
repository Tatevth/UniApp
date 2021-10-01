using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApp.Models
{
    class TeacherModel
    {
        public TeacherModel(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
            _students =new List<StudentModel>();
        }
        public int _id;
        public string _name;
        public int _age;
        public List<StudentModel> _students;
    }
}
