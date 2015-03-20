using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ORPortal_MVC.Models
{
    public class ORPortal_Db:DbContext
    {
        public ORPortal_Db()
            : base("name=DefaultConnection")
        {
           

        }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineGroup> MachineGroups { get; set; }
        public DbSet<User> Users { get; set; }
    }
}