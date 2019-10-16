using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using connectevents.Models;
using Microsoft.AspNetCore.Http;

namespace connectevents.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ConnectEvent e = new ConnectEvent();
            ViewData["Events"] = e.getEventsFromDB();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddEvent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection formCollection)
        {
            Event newevent=new Event();
             foreach (var item in formCollection)
            {
                if(item.Key == "Name")
                {
                    newevent.Name = item.Value;
                }
                if(item.Key == "Location")
                {
                    newevent.Location = item.Value;
                }
                if(item.Key == "Id")
                {
                    newevent.Id = int.Parse(item.Value);
                }
                if(item.Key == "Date")
                {
                    newevent.Date =Convert.ToDateTime(item.Value);
                }
                if(item.Key == "TimeStart")
                {
                    newevent.TimeStart =Convert.ToString(item.Value);

                }
                 if(item.Key == "ts")
                {
                    newevent.ts =Convert.ToString(item.Value);
                }
                if(item.Key == "TimeFinish")
                {
                    newevent.TimeFinish =Convert.ToString(item.Value);
                }
                 if(item.Key == "tf")
                {
                    newevent.tf =Convert.ToString(item.Value);
                }
                
                if(item.Key == "Details")
                {
                    newevent.Details =item.Value;
                }
            }
            ConnectEvent e = new ConnectEvent();
            e.addEventToDB(newevent);
            ViewData["Events"] = e.getEventsFromDB();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
