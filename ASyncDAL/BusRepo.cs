using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncDAL
{
    public class BusRepo : IBusRepo
    {
        private BusDbContext db;

        public BusRepo (BusDbContext busDbContext)
        {
            db = (BusDbContext)busDbContext;
        }

        public async Task<Bus> GetByID(int id)
        {
            return await db.Set<Bus>().SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<Bus>> GetAll()
        {
            return await db.Set<Bus>().ToListAsync();
        }
    }
}
