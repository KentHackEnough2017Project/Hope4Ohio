using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hope4Ohio.Models
{
    public class PatientContext: DbContext
    {
        public DbSet<Patient> Patient { get; set; }
    }
}