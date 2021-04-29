using Banking.API.Interfaces;
using Banking.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.API.Database;

namespace Banking.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly BankContext _db;

        public StudentService(BankContext context)
        {
            _db = context;
        }

        public bool AddStudent(Student student)
        {
            _db.Students.Add(student);

            var st = _db.Students.FirstOrDefault(x => x.StudentId == "552250d8-12e3-4033-aef8-32058722d2fa");
            if (st != null)
            {
                st.FirstName = "Marta";

            }

            if (_db.SaveChanges() == 1)
                return true;
            else
                return false;
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }

    }
}
