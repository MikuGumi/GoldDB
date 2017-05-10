using Gold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gold.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Skill data = new Skill();
            var model = new List<GoldViewModels>();
            var list = data.AccountBook.ToList();
            
            foreach (var item in list)
            {
                var coins = new GoldViewModels();
                coins.Sort = item.Categoryyy;
                coins.Date = item.Dateee;
                coins.Coin = item.Amounttt;
                coins.Remark = item.Remarkkk;
                model.Add(coins);
            }

            //Random rand = new Random();
            //var model = new List<GoldViewModels>();
            //GoldViewModels coins;

                //for (int i = 0; i < 200; i++)
                //{
                //    coins = new GoldViewModels();
                //    int type = rand.Next(2);
                //    if (type == 0)
                //    {
                //        coins.Sort = "支出";
                //    }
                //    else
                //    {
                //        coins.Sort = "收入";
                //    }
                //    coins.Date = DateTime.Now.AddDays(rand.Next(10000));
                //    coins.Coin = rand.Next(10000);
                //    model.Add(coins);
                //};
                return View(model);
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