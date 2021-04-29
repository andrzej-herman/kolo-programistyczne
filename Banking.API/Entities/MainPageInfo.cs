using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Entities
{
    public class MainPageInfo
    {
        [Key]
        public string MainPageInfoId { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
