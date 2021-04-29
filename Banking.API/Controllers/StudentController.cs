using Banking.API.Entities;
using Banking.API.Interfaces;
using Banking.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService service)
        {
            _studentService = service;
        }


        [HttpGet("/api/students")]
        public string GetStudents()
        {
            Student st = new Student();
            st.StudentId = Guid.NewGuid().ToString();
            st.FirstName = "Tomasz";
            st.LastName = "Kowalski";
            st.AlbumNumber = "79877";
            st.DateOfBirth = new DateTime(1990, 3, 4);
            _studentService.AddStudent(st);

            var studentList = _studentService.GetStudents();
            return JsonConvert.SerializeObject(studentList);

        }





    }
}
