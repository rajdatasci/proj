using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using connectevents.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace connectevents.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsFromDB();
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

         public IActionResult List( int Id)
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsFromDB(Id);
            return View();
        }
        [HttpPost]
        public IActionResult Index(String name, String location,DateTime date,string timeStart, string ts, string timeFinish, string tf, string details, IFormFile picture )
        {
            Event newevent=new Event();

            string pictureUrl = null;
            if(picture.Length > 0)
            {
                var fileName = Path.GetFileName(picture.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/images", fileName);
                var stream = new FileStream(filePath, FileMode.Create);
                picture.CopyTo(stream);
                pictureUrl = "/images/" + fileName;

            }
            newevent.Name=name;
            newevent.Location=location;
            newevent.Date=date;
            newevent.TimeStart =timeStart;
            newevent.ts=ts;
            newevent.TimeFinish=timeFinish;
            newevent.tf=tf;
            newevent.PictureUrl=pictureUrl;

            ConnectEvent e = new ConnectEvent();
            e.addEventToDB(newevent);
            ViewBag.Event = e.getEventsFromDB();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
