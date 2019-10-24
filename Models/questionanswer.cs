using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;

namespace connectevents
{

    public class Questionanswer
    {
        private MySqlConnection CreateConnection()
           {
               string connection = "server=localhost;database=eventconnect;user=root;password=root;port=3306";
               MySqlConnection con = new MySqlConnection(connection);
               con.Open();
               return con;
            }
        public List<Question> getQuestions(int Id)
        {
         
            List<Question> questions= new List<Question>();
             
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand($"select * from question where eventid={Id}",con);

            // executy the command
            var result = cmd.ExecuteReader();

            // prepare our results
            while(result.Read())
            {
                Question q = new Question();
                q.Id = Convert.ToInt32(result["id"]);
                q.Quest =result["question"].ToString();
                questions.Add(q);
            }
            con.Close();
         return questions;

   
        }
         
        public void addQuestionToDB(Question q)
        {
            var con=this.CreateConnection();
            string cmdtext=$"insert into question(question,eventid) values('{q.Quest}',{q.EventId})";
            MySqlCommand cmd = new MySqlCommand(cmdtext,con);
            cmd.ExecuteNonQuery();

        }
        public void addAnswer(Answer a)
        {
            var con=this.CreateConnection();
            string cmdtext=$"insert into answer(answer,questionid) values('{a.answer}',{a.QuestId})";
            MySqlCommand cmd = new MySqlCommand(cmdtext,con);
            cmd.ExecuteNonQuery();

        }
        public List<Answer> getAnswer(int Id)
        {
         
            List<Answer> answers= new List<Answer>();
             
            // creating and opening the mysql connection
            var con = this.CreateConnection();

            // creating the mysql command/query that I want to run
            MySqlCommand cmd = new MySqlCommand($"select * from answer where questionid={Id}",con);

            // executy the command
            var result = cmd.ExecuteReader();

            // prepare our results
            while(result.Read())
            {
                Answer a = new Answer();
                a.Id = Convert.ToInt32(result["id"]);
                a.answer =result["answer"].ToString();
                answers.Add(a);
            }
            con.Close();
             return answers;

   
        }
    }
}