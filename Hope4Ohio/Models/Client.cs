using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hope4Ohio.Models
{
    public class Client
    {
        [Key]
        public int PatientId { get; set; }

        public string FirstName { get; set; }
    }
}