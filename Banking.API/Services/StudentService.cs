using Banking.API.Interfaces;
using Banking.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            return new List<Student>()
             {
                 new Student(1, "Tomasz", "Nowak", "73456"),
                 new Student(2, "Anna", "Kowalska", "70122"),
                 new Student(3, "Marcin", "Rak", "753234")
             };
        }

    }
}
