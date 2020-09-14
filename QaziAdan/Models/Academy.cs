using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QaziAdan.Models
{
    public class Academy
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string phone_number { get; set; }
        public string fee { get; set; }
        public string owner_name { get; set; }
        
    }

    public class AcademyDBContext : DbContext
    {
        public DbSet<Academy> Academys { get; set; }
    }
}