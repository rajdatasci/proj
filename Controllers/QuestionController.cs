using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace connectevents.Controllers
{
  public class QuestionController : Controller
  {
      [HttpPost]
      public IActionResult AddQuestion( int id,string question)
        {
            ConnectEvent e = new ConnectEvent();
            ViewBag.Event = e.getEventsFromDB(id);
            Questionanswer questans= new Questionanswer();
            Question q = new Question();
            q.Quest=question;
            q.EventId=id;
            questans.addQuestionToDB(q);
            ViewBag.QUEST =questans.getQuestions(id);
            return View("List");
        }

        public IActionResult AddAnswer(int Qid, int Id, string ans)
        {
          Questionanswer questans= new Questionanswer();
            
            Answer a= new Answer();
            a.answer=ans;
            a.QuestId=Qid;
            questans.addAnswer(a);
            ViewBag.ANS =questans.getAnswer(Qid);
            ConnectEvent e = new ConnectEvent();
           ViewBag.Event = e.getEventsFromDB(Id);
           ViewBag.QUEST =questans.getQuestions(Id);   
            return View("List");
            
        }
        public IActionResult GetAnswers(int Qid, int Id)
        {
          Questionanswer question= new Questionanswer();
          ConnectEvent e = new ConnectEvent();
          ViewBag.Event = e.getEventsFromDB(Id);
          ViewBag.QUEST =question.getQuestions(Id);   
          ViewBag.ANS =question.getAnswer(Qid);
          return View("List");
        }
           
       
  }
}