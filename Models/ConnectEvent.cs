using System;
using System.Collections.Generic;
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
            string cmdtext=$"insert into event(name, location,date,timestart,timefinish,details, picture,userid) values('{e.Name}','{e.Location}','{e.Date.ToShortDateString()}','{e.TimeStart}{e.ts}','{e.TimeFinish}{e.tf}','{e.Details}','{e.PictureUrl}',1)";
            MySqlCommand cmd = new MySqlCommand(cmdtext,con);
            cmd.ExecuteNonQuery();

        }
    }
}