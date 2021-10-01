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
        List<StudentModel> _students;
        public StudentService()
        {
            _students = new List<StudentModel>();
        }
        public void Add(StudentModel student)
        {
            _students.Add(student);
        }
        public void Update(StudentModel student)
        {
            StudentModel wrongStudent = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == student._id)
                {
                    wrongStudent = _students[i];
                    break;

                }
                int wrongStudentIdx = _students.IndexOf(wrongStudent);
                _students[wrongStudentIdx] = student;

            }

        }
        public void Delete(int Id)
        {
            StudentModel studentfordelete = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == Id)
                {
                    studentfordelete = _students[i];
                    break;
                }
                _students.Remove(studentfordelete);
            }
        }
        public StudentModel Get(int id)
        {
            StudentModel student = null;
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    student = _students[i];
                    break;
                }
            }
            return student;
        }
        public List<StudentModel> GetAll()
        {
            return _students;
        }
    }
}
