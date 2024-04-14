using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task123
{
    internal class Student
    {

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }

        public Student(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public enum ClassroomType
        {
            Backend,
            FrontEnd
        }
    }
}
