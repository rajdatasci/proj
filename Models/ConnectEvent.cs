using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;

namespace connectevents
{

    public class ConnectEvent
    {
        private MySqlConnection CreateConnection()
           {
               string connection = "server=localhost;database=eventconnect;user=root;password=root;port=3306";
               MySqlConnection con = new MySqlConnection(connection);
               con.Open();
               return con;
            }
        public List<Event> getEventsWeek()
        {
         
            List<Event> events= new List<Event>();
             
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand("select * from event where datediff(DATE(now()), DATE(`date`))<7 and ( DATE(`date`)>DATE(now()));",con);

            // executy the command
            var result = cmd.ExecuteReader();

            // prepare our results
            while(result.Read())
            {
                Event e = new Event();
                e.Id = Convert.ToInt32(result["id"]);
                e.Name = result["name"].ToString();
                e.Date = Convert.ToDateTime(result["Date"]);
                e.TimeStart=Convert.ToString(result["TimeStart"]);
                e.TimeFinish=Convert.ToString(result["TimeFinish"]);
                e.Location = result["location"].ToString();
                e.Details =result["details"].ToString();
                e.PictureUrl=result["picture"].ToString();
                events.Add(e);
            }
            con.Close();
        return events;

   
        }
         public List<Event> getEventsToday()
        {
         
            List<Event> events= new List<Event>();
             
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand("select * from event where DATE(`date`)=DATE(now());",con);

            // executy the command
            var result = cmd.ExecuteReader();

            // prepare our results
            while(result.Read())
            {
                Event e = new Event();
                e.Id = Convert.ToInt32(result["id"]);
                e.Name = result["name"].ToString();
                e.Date = Convert.ToDateTime(result["Date"]);
                e.TimeStart=Convert.ToString(result["TimeStart"]);
                e.TimeFinish=Convert.ToString(result["TimeFinish"]);
                e.Location = result["location"].ToString();
                e.Details =result["details"].ToString();
                e.PictureUrl=result["picture"].ToString();
                events.Add(e);
            }
            con.Close();
        return events;

   
        }
     
        public List<Event> getEventsFromDB()
        {
            List<Event> events= new List<Event>();
             
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand("select * from event", con);

            // executy the command
            var result = cmd.ExecuteReader();

            // prepare our results
            while(result.Read())
            {
                Event e = new Event();
                e.Id = Convert.ToInt32(result["id"]);
                e.Name = result["name"].ToString();
                e.Date = Convert.ToDateTime(result["Date"]);
                e.TimeStart=Convert.ToString(result["TimeStart"]);
                e.TimeFinish=Convert.ToString(result["TimeFinish"]);
                e.Location = result["location"].ToString();
                e.Details =result["details"].ToString();
                e.PictureUrl=result["picture"].ToString();
                events.Add(e);
            }
            con.Close();
        return events;

        }
        public List<Event> search(DateTime d)
        {
            List<Event> events=new List<Event>();
             var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand($"select * from event where datediff(DATE(now()), DATE(`{d}`))<7", con);

            // executy the command
            var result = cmd.ExecuteReader();
            while(result.Read())
            {
                Event e = new Event();
                e.Id = Convert.ToInt32(result["id"]);
                e.Name = result["name"].ToString();
                e.Date = Convert.ToDateTime(result["Date"]);
                e.TimeStart=Convert.ToString(result["TimeStart"]);
                e.TimeFinish=Convert.ToString(result["TimeFinish"]);
                e.Location = result["location"].ToString();
                e.Details =result["details"].ToString();
                e.PictureUrl=result["picture"].ToString();
                events.Add(e);
            }
            con.Close();
        return events;

        }
        public Event getEventsFromDB(int Id)
        {
            
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand($"select * from event where id={Id}", con);

            // executy the command
            var result = cmd.ExecuteReader();
            
            Event e = new Event();


            // prepare our results
            while(result.Read())
            {
                e.Id = Convert.ToInt32(result["id"]);
                e.Name = result["name"].ToString();
                e.Date = Convert.ToDateTime(result["Date"]);
                e.TimeStart=Convert.ToString(result["TimeStart"]);
                e.TimeFinish=Convert.ToString(result["TimeFinish"]);
                e.Location = result["location"].ToString();
                e.Details =result["details"].ToString();
                e.PictureUrl=result["picture"].ToString();
            }   
            con.Close();
            return e;

        }
        public void addEventToDB(Event e)
        {
            var con=this.CreateConnection();
            string cmdtext=$"insert into event(name, location,date,timestart,timefinish,details, picture,userid) values('{e.Name}','{e.Location}','{e.Date.ToShortDateString()}','{e.TimeStart}{e.ts}','{e.TimeFinish}{e.tf}','{e.Details}','{e.PictureUrl}',{e.userid})";
            MySqlCommand cmd = new MySqlCommand(cmdtext,con);
            cmd.ExecuteNonQuery();

        }
    }
}