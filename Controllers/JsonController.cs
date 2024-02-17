using JsonDownload.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsonDownload.Controllers
{
    public class JsonController : Controller
    {
        private int page = 1;
        private int pageSize = 20;
        private int currentPage;
        public int CurrentPage 
        { 
            get => currentPage;
            set
            {
                if (value <= 1)
                    currentPage = 1;
                else
                    currentPage = value;
            }
        }
        // GET: Json
        public async Task<ActionResult> Index()
        {
            var model = await JsonService.GetDataAsync_Youbike();

            //顯示第幾頁，當參數< 1時會設定為第1頁，避免不正確輸入       
            currentPage = page;


            //將取得資料model轉成PagedList
            var pageModel = model.OrderBy(m=>m.sno).ToPagedList(currentPage, pageSize);

            return View(pageModel);
        }

        public async Task<ActionResult> GetPlace()
        {
            var model = await JsonService.GetDataAsync_TravelPlace();

            ////顯示第幾頁，當參數< 1時會設定為第1頁，避免不正確輸入         //原始寫法
            //var currentPage = page < 1 ? 1 : page;

            ////每頁資料筆數
            //var pageSize = 20;

            currentPage = page;
            //將取得資料model轉成PagedList
            var pageModel = model.OrderBy(m => m.Id).ToPagedList(currentPage, pageSize);

            return View(pageModel);
        }


        public async Task<ActionResult> GetBusTaxi()
        {
            
            var model = await JsonService.GetDataAsync_BusTaxi();
            currentPage = page;

            //將取得資料model轉成PagedList
            var pageModel = model.OrderBy(m=>m.name).ToPagedList(currentPage, pageSize);

            return View(pageModel);
        }

        
    }
}