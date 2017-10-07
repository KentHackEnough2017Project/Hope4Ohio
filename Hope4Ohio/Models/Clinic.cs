using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hope4Ohio.Models
{
    public class Clinic
    {
        [Key]
        public int ClinicId { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string TotalBeds { get; set; }
        public string OpenBeds { get; set; }

        public virtual Patient Patient { get; set; }
    }
}