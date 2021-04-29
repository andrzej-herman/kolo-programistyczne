using Banking.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        void AddStudent(Student student);
    }
}
