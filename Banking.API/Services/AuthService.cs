using Banking.API.Dto;
using Banking.API.Entities;
using Banking.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Services
{
    public class AuthService : IAuthService
    {
        public Task<User> Login(LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
