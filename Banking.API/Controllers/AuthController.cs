using Banking.API.Dto;
using Banking.API.Helpers;
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
            LoginIdentifier type = LoginIdentifier.Login;
            if (dto.Login.IsCustomerNumber())
                type = LoginIdentifier.CustomerNumber;

            if (dto.Login == "admin" && type == LoginIdentifier.Login
                || dto.Login == "60001" && type == LoginIdentifier.CustomerNumber)
            {
                string userId = await _service.LoginAdminAsync(dto.Login, dto.Password, type);
                if (userId != null)
                {
                    var token = GenerateToken(userId);
                    return Ok(new { token = token, usertype = "admin" });
                }
                else
                    return Unauthorized();
            }
            else
            {
                // user
                return Unauthorized();
            }
        }

        private object GenerateToken(string userId)
        {
            // do zrobienia w październiku: wygenerować token 
            throw new NotImplementedException();
        }
    }
}

