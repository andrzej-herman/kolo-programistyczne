using Banking.API.Dto;
using Banking.API.Entities;
using Banking.API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAdminAsync(string identifier, string plainPassword, LoginIdentifier type);
    }
}
