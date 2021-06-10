using Banking.API.Dto;
using Banking.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("/api/auth/login")]
        public async Task<IActionResult> LoginAsync(LoginDto dto)
        {
            //var user = _service.Login(dto);



            return Ok("Logowanie udane");
        }
    }
}
