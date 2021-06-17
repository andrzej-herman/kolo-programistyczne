using Banking.API.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Banking.API.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public UserType UserType { get; set; }
        public string Login { get; set; }
        public string CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public int NumberOfFailedLoginAttempts { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({CustomerNumber})";
        }
   
    }

}
