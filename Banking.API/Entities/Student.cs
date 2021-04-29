using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Entities
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AlbumNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        [NotMapped]
        public string TelephoneNumber { get; set; }

        public string Initials
        {
            get
            {
                if (FirstName != null && LastName != null)
                    return FirstName.Substring(0, 1).ToUpper() + LastName.Substring(0, 1).ToUpper();
                else
                    return "";
            }
        }
    }
}
