using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace DatabaseHandle.DAL
{
    public class JsonQuestion
    {
        public string question { get; set; }
        public Choices choices { get; set; }
        public class Choices
        {
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string D { get; set; }
        }
        public JsonQuestion()
        {
            question = null;
            choices = new Choices();
            choices.A = null;
            choices.B = null;
            choices.C = null;
            choices.D = null;
        }
        public static JsonQuestion getJsonQuestion(string questionContent)
        {
            JsonQuestion json = new JsonQuestion();
            json.question = questionContent;
            return json;
        }
        public static JsonQuestion getJsonQuestion(string questionContent,string choiceA, string choiceB, string choiceC, string choiceD)
        {
            JsonQuestion json = new JsonQuestion();
            json.question = questionContent;
            json.choices.A = choiceA;
            json.choices.B = choiceB;
            json.choices.C = choiceC;
            json.choices.D = choiceD;
            return json;
        }
    }
    public partial class DAL_Question
    {
        public string QuestionContent { get; set; }
        public string Type { get; set; }
        public string AnswerKey { get; set; }
        public DAL_Question(Question question)
        {
            if (question is Multiple_Choice)
            {
                Multiple_Choice myMC = (Multiple_Choice)question;
                Type = "mc";
                JsonQuestion json = JsonQuestion.getJsonQuestion(myMC.QuestionContent, myMC.ChoiceA, myMC.ChoiceB, myMC.ChoiceC, myMC.ChoiceD);
                QuestionContent =Newtonsoft.Json.JsonConvert.SerializeObject(json);
            }
            else if (question is Compound)
            {
                Compound myCP = (Compound)question;
                Type = "cp";
                JsonQuestion json = JsonQuestion.getJsonQuestion(myCP.QuestionContent, myCP.ChoiceA, myCP.ChoiceB, myCP.ChoiceC, myCP.ChoiceD);
                QuestionContent = Newtonsoft.Json.JsonConvert.SerializeObject(json);
            }
            else if (question is Fill_In)
            {
                Fill_In myFi = (Fill_In)question;
                Type = "fi";
                JsonQuestion json = JsonQuestion.getJsonQuestion(myFi.QuestionContent);
                QuestionContent = JsonConvert.SerializeObject(json);
            }
            else if (question is Fast)
            {
                Fast myFa = (Fast)question;
                Type = "fs";
                JsonQuestion json = JsonQuestion.getJsonQuestion(myFa.QuestionContent);
                QuestionContent = JsonConvert.SerializeObject(json);
            }
            else if (question is True_False)
            {
                True_False myTf = (True_False)question;
                Type = "tf";
                JsonQuestion json = JsonQuestion.getJsonQuestion(myTf.QuestionContent);
                QuestionContent = JsonConvert.SerializeObject(json);
            }

            AnswerKey = question.AnswerKey;
        }
        
    }
    public partial class dbConnection
    {
        private SqlConnection connection;
        private string sqlString = "server=localhost;database=ITB_CK;user id=sa;pwd=123456";
        public dbConnection()
        {
            connection = new SqlConnection(sqlString);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                if (connection.State == ConnectionState.Closed)
                    throw new Exception();

            }
            catch
            {
                connection.Close();
            }
            
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        public int InsertQuestions(List<Question> questions)
        {
            int dem = 0;

            SqlCommand cmd = null;
            foreach(Question question in questions)
            {


                DAL_Question dAL_Question = new DAL_Question(question);

                cmd = new SqlCommand();
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@myJSON", dAL_Question.QuestionContent);
                //cmd.Parameters.AddWithValue("@myType", dAL_Question.Type);
                //cmd.Parameters.AddWithValue("@myAnswer", dAL_Question.AnswerKey);
                cmd.Connection = connection;
                cmd.CommandText = "exec InsertQuestion @myJSON = N'" + dAL_Question.QuestionContent + "'" +
                                                    ", @myType = '" + dAL_Question.Type + "'" +
                                                    ", @myAnswer = '" + dAL_Question.AnswerKey + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dem = dem + reader.GetInt32(0);
                    reader.Close();
                }
            }
            if (dem == questions.Count)
            {
                connection.Close();
                return 1;
            }
            connection.Close(); 
            return 0;
        }

        public int FakeData()
        {
            SqlCommand cmd = null;
            cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "exec FakeContestData";
        }
    }
}
