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

        public IActionResult Events()
        {
            return View();
        }
         public IActionResult EventsWeek()
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsWeek();
            return View("listevent"); 
           
        }
        public IActionResult EventsToday()
        {
            ViewBag.Event = null;
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsToday();
            return View("listevent");  
        }
        public IActionResult AddEvent()
        {
             var user = HttpContext.Session.GetString("user");
            if(user == null)
            {
              return Redirect("/auth/login");
            }
            else
            {
              //ViewData["Message"] = "Add New Event.";
              return View();
            }
        }

         public IActionResult List( int Id)
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsFromDB(Id);
            return View();
        }
         public IActionResult ListEvent()
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsFromDB();
            return View();
        }
        [HttpPost]
        public IActionResult Index(String name, String location,DateTime date,string timeStart, string ts, string timeFinish, string tf, string details, IFormFile picture )
        {
            var userId = HttpContext.Session.GetString("id");
             if(userId == null)
            {
              return Redirect("/auth/login");
            }
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
            newevent.Details=details;
            newevent.PictureUrl=pictureUrl;
            newevent.userid=Convert.ToInt32(userId);

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
