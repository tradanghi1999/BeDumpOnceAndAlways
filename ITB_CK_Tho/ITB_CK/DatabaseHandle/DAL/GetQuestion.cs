using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DatabaseHandle.Model;
using System.Data.SqlClient;
namespace DatabaseHandle.DAL
{
    public partial class dbConnection
    {
        public Question GetQuestion(string questionId)
        {
            SqlDataReader reader = null;
            Question question = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "exec GetQuetion @questionId='" + questionId + "'";
                cmd.Connection = connection;
                //
                //List<Model.Team> teamS = new List<Model.Team>();
                //
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    question = Question.CreateNewQuestion(reader.GetString(1));
                    //string teamID = reader.GetString(0);
                    //string teamName = reader.GetString(1);
                    //int score = reader.GetInt32(2);
                    //string round1State = reader.GetString(3);
                    //string round2State = reader.GetString(4);
                    //string round3State = reader.GetString(5);
                    //DateTime dateTime = reader.GetDateTime(6);
                    //
                    //team = new Model.Team();
                    //team.ID = teamID;
                    //team.Name = teamName;
                    //team.Round1State = round1State;
                    //team.Round2State = round2State;
                    //team.Round3State = round3State;
                    //team.LastModified = dateTime;
                    ////
                    //teamS.Add(team);

                    question.Id = questionId;
                    question.QuestionContent = reader.GetString(2);
                    question.AnswerKey = reader.GetString(7);
                    question.Image64String = reader.GetString(8);
                    if(!reader.IsDBNull(9))
                        question.ImageRelativePath = reader.GetString(9);
                        
                    //
                    if(question is Multiple_Choice)
                    {
                        Multiple_Choice myMC = (Multiple_Choice)question;
                        myMC.ChoiceA = reader.GetString(3);
                        myMC.ChoiceB = reader.GetString(4);
                        myMC.ChoiceC = reader.GetString(5);
                        myMC.ChoiceD = reader.GetString(6);
                    }
                    else if(question is Compound)
                    {
                        Compound myCp = (Compound)question;
                        myCp.ChoiceA = reader.GetString(3);
                        myCp.ChoiceB = reader.GetString(4);
                        myCp.ChoiceC = reader.GetString(5);
                        myCp.ChoiceD = reader.GetString(6);
                    }
                }
                //
                reader.Close();
                connection.Close();
                return question;
            }
            catch(Exception e)
            {
                reader.Close();
                connection.Close();
                return null;
            }
              
        }
    }
}
