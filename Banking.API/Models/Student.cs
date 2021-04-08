using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Models
{
    public class Student
    {
        public Student(int id, string firstname, string lastname, string album)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            AlbumNumber = album;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AlbumNumber { get; set; }
    }
}
