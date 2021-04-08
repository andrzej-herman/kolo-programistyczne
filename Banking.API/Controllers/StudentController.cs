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
            var studentList = _studentService.GetStudents();
            return JsonConvert.SerializeObject(studentList);
        }



    }
}
