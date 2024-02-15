using JsonDownload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace JsonDownload.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public async Task<ActionResult> Index()
        {
            var model = await JsonService.GetDataAsync_Youbike();
            return View(model);
        }

        public async Task<ActionResult> GetPlace()
        {
            var model = await JsonService.GetDataAsync_TravelPlace();
            return View(model);
        }


        public async Task<ActionResult> GetBusTaxi()
        {
            var model = await JsonService.GetDataAsync_BusTaxi();
            return View(model);
        }
    }
}