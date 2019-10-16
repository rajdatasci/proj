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
                events.Add(e);
            }
            con.Close();
        return events;

        }
        public void addEventToDB(Event e)
        {
            var con=this.CreateConnection();
            string cmdtext=$"insert into event values({e.Id},'{e.Name}','{e.Location}','{e.Date.ToShortDateString()}','{e.TimeStart}','{e.TimeFinish}','{e.Details}',1)";
            MySqlCommand cmd = new MySqlCommand(cmdtext,con);
            cmd.ExecuteNonQuery();

        }
    }
}