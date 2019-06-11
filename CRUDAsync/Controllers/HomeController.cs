using ASyncDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CRUDAsync.Controllers
{
    public class HomeController : Controller
    {
        private IBusRepo _busRepo = new BusRepo(new BusDbContext());

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var Buses = await _busRepo.GetAll();
            return View(Buses);
        }

        [HttpGet]
        public async Task<ActionResult> GetByID(int id)
        {
            var bus = await _busRepo.GetByID(id);
            return View(bus);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}