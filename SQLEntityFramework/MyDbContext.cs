using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SQLEntityFramework
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base ("DbConnectionString")
        {        
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }



    }
}
