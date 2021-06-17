using Banking.API.Database;
using Banking.API.Dto;
using Banking.API.Entities;
using Banking.API.Helpers;
using Banking.API.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly BankContext _db;

        public AuthService(BankContext db)
        {
            _db = db;
        }

        public async Task<string> LoginAdminAsync(string identifier, string plainPassword, LoginIdentifier type)
        {
            User user;
            if (type == LoginIdentifier.Login)
                user = await _db.Users.FirstOrDefaultAsync(x => x.Login == identifier.Trim());
            else
                user = await _db.Users.FirstOrDefaultAsync(x => x.CustomerNumber == identifier.Trim());

            if (user == null)
                return null;
            else
            {
                bool verified = BCrypt.Net.BCrypt.Verify(plainPassword, user.Password);
                if (!verified)
                    return null;
                else
                    return user.UserId;
            }
        }
    }
}




// bool verified = BCrypt.Net.BCrypt.Verify("adminsan2021", passwordHash);
// admin pass: adminsan2021