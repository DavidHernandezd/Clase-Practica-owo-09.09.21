using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9_09
{
    class Student
    {
        public int idstudent { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string country { get; set; }

        // metodo con la coleccion de datos.

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
            new Student{ idstudent=1001, firstname="Juan", lastname="paz", age=20, country="el salvador"},
            new Student{ idstudent=1002, firstname="Monica", lastname="maravilla", age=22, country="Panama"},
            new Student{ idstudent=1003, firstname="alfredo", lastname="Juarez", age=23, country="costarrica"},
            new Student{ idstudent=1004, firstname="Diego", lastname="Berrios", age=21, country="Guatemala"},
            new Student{ idstudent=1005, firstname="Maria", lastname="Hernandez", age=19, country="Nicaragua"},
            };
            return students;
        }
    }
}
