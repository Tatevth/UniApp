using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniApp.Models;

namespace UniApp.Services
{
    class StudentService
    {
        List<StudentModel> _student;  //create
        public StudentService()
        {
            _student = new List<StudentModel>();
        }
        public void Add(StudentModel student)
        {
            _student.Add(student);
        }
        public void Update(StudentModel student)
        {
            StudentModel wrongStudent = null;
            for (int i = 0; i < _student.Count; i++)
            {
                if (_student[i]._id == student._id)
                {
                    wrongStudent = _student[i];
                    break;

                }
                int wrongStudentIdx = _student.IndexOf(wrongStudent);
                _student[wrongStudentIdx] = student;

            }

        }
        public void Delete(int Id)
        {
            StudentModel studentfordelete = null;
            for (int i = 0; i < _student.Count; i++)
            {
                if (_student[i]._id == Id)
                {
                    studentfordelete = _student[i];
                    break;
                }
                _student.Remove(studentfordelete);
            }
        }
        public StudentModel Get(int id)
        {
            StudentModel student = null;
            for (int i = 0; i < _student.Count; i++)
            {
                if (_student[i]._id == id)
                {
                    student = _student[i];
                    break;
                }
            }
            return student;
        }
        public List<StudentModel> GetAll()
        {
            return _student;
        }
    }
}
