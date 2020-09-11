using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Configuration;
using DatabaseHandle.Model;
using DatabaseHandle.DAL;

namespace Team
{
    public class DAL
    {
        private string sqlString = ConfigurationManager.ConnectionStrings["dbConnectString"].ConnectionString;
        private SqlConnection connection;
        public DAL()
        {
            connection = new SqlConnection(sqlString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            try
            {
                string hostName = ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
                string programName = ConfigurationManager.ConnectionStrings["programName"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "exec LoginOrCheckIn " +
                                    "@programName = '" + programName + "'," +
                                    "@hostName = '" + hostName + "';";
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw;
            }
        }

        internal bool TeamIsDone(string teamId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["CheckTeamDone"].ConnectionString;
            if (teamId == null)
                cmd.Parameters.AddWithValue("@teamId", "");
            else
                cmd.Parameters.AddWithValue("@teamId", teamId);
            SqlDataReader reader = null;
            try
            {

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int kq = reader.GetInt32(0);
                    reader.Close();
                    connection.Close();

                    if (kq > 0)
                    {

                        return true;
                    }
                    return false;

                }
            }
            catch
            {
                if(reader != null)
                    reader.Close();

                connection.Close();

                return false;
            }
            return false;
            
        }

        internal Question GetNextQuestion(string teamId, string questionId)
        {
            //throw new NotImplementedException();
            try
            {
                //string hostName = ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
                //string programName = ConfigurationManager.ConnectionStrings["programName"].ConnectionString;
                //string teamID = ConfigurationManager.ConnectionStrings["teamID"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ConfigurationManager.ConnectionStrings["round1GetCommandToGetNextQuestion"].ConnectionString;
                cmd.Parameters.AddWithValue("@teamID", teamId);
                if (questionId == null)
                    cmd.Parameters.AddWithValue("@preQuestionId", "");
                else
                    cmd.Parameters.AddWithValue("@preQuestionId", "");

                Question question = null;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string questionSTT = reader.GetInt32(0) + "";
                    string questionID = reader.GetString(1);
                    question = (new dbConnection()).GetQuestion(questionID);
                    question.STT = questionSTT;
                }
                reader.Close();
                connection.Close();
                return question;
            }
            catch (Exception e)
            {
                //reader.Close();
                connection.Close();
                return null;
            }
        }

        internal string GetTeamIdExaming()
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["getTeamExaming"].ConnectionString;
            //
            //
            string kq = null;
            SqlDataReader reader = null;
            //List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                        kq = reader.GetString(0);
                }

            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return kq;
        }
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            finally
            {

            }
        }
    }
}
