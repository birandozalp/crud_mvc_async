using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASyncDAL
{
    public interface IBusRepo
    {
        Task<Bus> GetByID(int id);
        Task<List<Bus>> GetAll();
    }
}
