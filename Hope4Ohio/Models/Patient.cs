using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hope4Ohio.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}