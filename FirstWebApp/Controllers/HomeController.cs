using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //在ASP.NET MVC 裡，有提供了幾種物件來讓我們達到傳遞資料的方法，我們常用的定義如下：. Controller 和View - ViewData、ViewBag、ViewModel、TempData
            ViewData["pic_default"] = "/fonts/pic_bulboff.gif";
            ViewData["pic_off"] = "/fonts/pic_bulboff.gif";
            ViewData["pic_on"] = "/fonts/pic_bulbon.gif";

            // attempt to load HTML RAW by ViewData, through @Html.Raw(ViewData["surp_html"]), but ...
            //ViewData["surp_html"] = "<img id='Surprise' src=@ViewData['pic_default'] onload='play()' style='width: 100px'>";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to my website.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My name is John Blue.";

            return View();
        }
    }


}