using JsonDownload.Models;
using PagedList;
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
        public async Task<ActionResult> Index(int page = 1)
        {
            var model = await JsonService.GetDataAsync_Youbike();

            //顯示第幾頁，當參數< 1時會設定為第1頁，避免不正確輸入
            var currentPage = page < 1 ? 1 : page;

            //每頁資料筆數
            var pageSize = 20;

            //將取得資料model轉成PagedList
            var pageModel = model.OrderBy(m=>m.sno).ToPagedList(currentPage, pageSize);

            return View(pageModel);
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