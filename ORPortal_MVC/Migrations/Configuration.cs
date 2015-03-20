namespace ORPortal_MVC.Migrations
{
    using ORPortal_MVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ORPortal_MVC.Models.ORPortal_Db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ORPortal_MVC.Models.ORPortal_Db context)
        {
            context.MachineGroups.AddOrUpdate(i => i.Name,

                   new MachineGroup { Name = "Che", Id=1 },
                   new MachineGroup { Name = "AirCleaner", Id=2 },
                   new MachineGroup { Name = "TubeFinal", Id=3 },
                   new MachineGroup { Name = "Group1", Id=4 }
                   
                 );
            context.Machines.AddOrUpdate(i => i.Name,

                   new Machine { Name = "Che", Id = 1 },
                   new Machine { Name = "AirCleaner", Id = 2 },
                   new Machine { Name = "TubeFinal", Id = 3 },
                   new Machine { Name = "Group1", Id = 4 }

                 );
            context.Users.AddOrUpdate(t => t.Name,
                new User { Name = "user1", Password = "password" }
                    );

            
        }
    }
}
