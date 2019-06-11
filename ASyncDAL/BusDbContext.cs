using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncDAL
{
    public class BusDbContext:DbContext
    {
        public BusDbContext():base("BusConnection")
        {
            //Supposed to be empty?
        }

        public System.Data.Entity.DbSet<ASyncDAL.Bus> Buses { get; set; }
    }
}
