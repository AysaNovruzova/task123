using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task123.Student;

namespace task123
{
    internal class Classroom
    {

        private static int _nextId = 1;
        public int Id { get; }
        public string Name { get; }
        public ClassroomType Type { get; }
        private Student[] _students;
        private int _studentCount = 0;

        public Classroom(string name, ClassroomType type)
        {
            Id = _nextId++;
            Name = name;
            Type = type;

            if (type == ClassroomType.Backend)
            {
                _students = new Student[20];
            }
            else
            {
                _students = new Student[15];
            }
        }

        // Sinifa yeni telebe əlavə etmək
        public void AddStudent(Student student)
        {
            if (_studentCount < _students.Length)
            {
                _students[_studentCount++] = student;
            }
            else
            {
                throw new InvalidOperationException("Sinif limitini keçdi.");
            }
        }

     
        public Student FindStudentById(int id)
        {
            foreach (var student in _students)
            {
                if (student != null && student.Id == id)
                {
                    return student;
                }
            }
            throw new StudentNotFoundException("Telebe tapılmadı.");
        }

        public void DeleteStudent(int id)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] != null && _students[i].Id == id)
                {
                    _students[i] = null;
                    _studentCount--;
                    return;
                }
            }
            throw new StudentNotFoundException("Telebe tapılmadı.");
        }
    }
}
