using Banking.API.Dto;
using Banking.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Interfaces
{
    public interface IAuthService
    {
        Task<User> Login(LoginDto dto);
    }
}
