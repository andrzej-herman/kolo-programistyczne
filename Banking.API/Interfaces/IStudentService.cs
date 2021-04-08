using Banking.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
