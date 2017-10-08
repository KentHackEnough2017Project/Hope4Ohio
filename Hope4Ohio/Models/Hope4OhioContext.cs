using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hope4Ohio.Models
{
    public class Hope4OhioContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Hope4OhioContext() : base("name=Hope4OhioContext")
        {
        }

        public System.Data.Entity.DbSet<Hope4Ohio.Models.Clinic> Clinics { get; set; }

        public System.Data.Entity.DbSet<Hope4Ohio.Models.Patient> Patients { get; set; }

    }
}
