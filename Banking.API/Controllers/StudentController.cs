using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {


        [HttpGet("/api/students")]
        public IActionResult GetStudents()
        {
            return View();
        }



    }
}
