using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdvertsWebApp.Models;

namespace AdvertsWebApp.Controllers
{
    public class HomeController : Controller
    {
        //Konstruktors
        public HomeController()
        {
            adverts = new List<Advert>();
            Advert ad = new Advert(); // Nepieciešams pievienot using AdvertsWebApp.Models
            ad.AdvertID = 1;
            ad.Name = "BMW";
            ad.AdvertText = "Šis ir labs BMW";
            ad.Price = 2000.95;
            ad.CreationTime = DateTime.Now;

            Advert homeAd = new Advert(); 
            homeAd.AdvertID = 2;
            homeAd.Name = "Māja";
            homeAd.AdvertText = "Liela māja";
            homeAd.Price = 12000;
            homeAd.CreationTime = new DateTime(1999,12,31);

            adverts.Add(ad);
            adverts.Add(homeAd);
        }
        private List<Advert> adverts; //DB imitācija, saraksts

        //Šī f-ja tiek izsaukta, kad tiek pieprasīts weblapas bāzes ceļš
        public IActionResult Index()
        {
            //Izsaucam view f-ju, lai uzģenerētu html rezultātu no Index.cshtml faila, tajā iekšā izmantojot datus, kas pieejami adverts sarakstā
            return View(adverts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Advert(int advertID)
        {
            foreach (var ad in adverts)
            {
                if (ad.AdvertID == advertID) // meklē sludinājumu, kuram sakrīt ID
                {
                    return View(ad);
                }
            }
            return View();
        }
    }
}
