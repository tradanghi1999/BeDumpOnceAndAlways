using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//
using PointScreen;
using static IT.IT_Model;
using static PointScreen.Model;
using DatabaseHandle.DAL;
using DatabaseHandle.Model;

namespace IT
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

        internal List<ResultDetail> GetResultDetailsWithQuesId(string questionID)
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["GetResultDetailRound3"].ConnectionString;
            cmd.Parameters.AddWithValue("@questionID", questionID);
            //
            //
            //string kq = null;
            SqlDataReader reader = null;
            List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ResultDetail myResultDetail = new ResultDetail();
                    myResultDetail.ID = reader.GetString(0);
                    myResultDetail.Team = (new PointScreen.DAL()).GetTeam(reader.GetString(1));
                    myResultDetail.RoundNum = reader.GetInt32(7);
                    myResultDetail.QuestionNum = reader.GetInt32(8);
                    myResultDetail.Question = (new dbConnection()).GetQuestion(reader.GetString(2));
                    myResultDetail.Score = reader.GetInt32(3);
                    myResultDetail.Point = reader.GetInt32(9);
                    myResultDetail.IsCorrect = reader.GetBoolean(4);
                    //
                    resultDetails.Add(myResultDetail);
                }

            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return resultDetails;
        }

        internal void SetAutoMode()
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SetAutoMode";
            int kq = 0;
            //SqlDataReader reader = null;
            //List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                //reader.Close();
                connection.Close();
            }

            return;
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
                    cmd.Parameters.AddWithValue("@preQuestionId", questionId);

                Question question = null;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string questionSTT = reader.GetInt32(0) +"";
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

        internal void MakeTeamRound3Ready()
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MakeRound3Ready";
            int kq = 0;
            //SqlDataReader reader = null;
            //List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                //reader.Close();
                connection.Close();
            }

            return;
        }

        internal void ShowKey()
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["ShowKeyCMD"].ConnectionString;
            int kq = 0;
            //SqlDataReader reader = null;
            //List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                //reader.Close();
                connection.Close();
            }

            return;
        }

        internal bool UpdateResultDetail(string quesionId, string v1, bool? doiDauTienState, string v2, bool? doiThuHaiState)
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["UpdateResultDetailRound3"].ConnectionString;
            cmd.Parameters.AddWithValue("@questionID", quesionId);
            cmd.Parameters.AddWithValue("@teamIdDoiDauTien", v1);
            if(doiDauTienState == null)
                cmd.Parameters.AddWithValue("@stateDoiDauTien", "");
            else
                cmd.Parameters.AddWithValue("@stateDoiDauTien", doiDauTienState);
            cmd.Parameters.AddWithValue("@teamIdDoiThuHai", v2);

            if (doiThuHaiState == null)
                cmd.Parameters.AddWithValue("@stateDoiThuHai", "");
            else
                cmd.Parameters.AddWithValue("@stateDoiThuHai", doiThuHaiState);
            //
            //
            int kq = 0;
            //SqlDataReader reader = null;
            //List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                //reader.Close();
                connection.Close();
            }

            return kq > 0;
        }

        internal Question GetPreQuestion(string questionId)
        {
            try
            {
                //string hostName = ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
                //string programName = ConfigurationManager.ConnectionStrings["programName"].ConnectionString;
                //string teamID = ConfigurationManager.ConnectionStrings["teamID"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ConfigurationManager.ConnectionStrings["round3GetCommandToGetPreviousQuestion"].ConnectionString;
                //cmd.Parameters.AddWithValue("@teamID", teamId);
                if (questionId == null)
                    cmd.Parameters.AddWithValue("@thisQuestionId", "");
                else
                    cmd.Parameters.AddWithValue("@thisQuestionId", questionId);

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

        internal Question GetNextQuestion(string questionId)
        {
            try
            {
                //string hostName = ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
                //string programName = ConfigurationManager.ConnectionStrings["programName"].ConnectionString;
                //string teamID = ConfigurationManager.ConnectionStrings["teamID"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ConfigurationManager.ConnectionStrings["round3GetCommandToGetNextQuestion"].ConnectionString;
                if (questionId == null)
                    cmd.Parameters.AddWithValue("@preQuestionId", "");
                else
                    cmd.Parameters.AddWithValue("@preQuestionId", questionId);

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

        internal bool InsertPointRound2(string teamId, int point)
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["InsertPointRound2"].ConnectionString;
            cmd.Parameters.AddWithValue("@teamId", teamId);
            cmd.Parameters.AddWithValue("@teamPoint", point);
            int kq = 0;
            //
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return kq > 0;
        }

        internal bool MakeTeamDone(string teamId)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["MakeDone"].ConnectionString;
            cmd.Parameters.AddWithValue("@teamId", teamId);
            int kq = 0;
            //
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return kq > 0;
        }

        internal bool MakeExaming(string teamId)
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["MakeExaming"].ConnectionString;
            cmd.Parameters.AddWithValue("@teamId", teamId);
            int kq = 0;
            //
            try
            {
                kq = cmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
            return kq > 0;
        }

        internal string CheckTeamNumberOfRightAnswerRound1(string teamId)
        {
            //throw new NotImplementedException();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = ConfigurationManager.ConnectionStrings["round1GetRightRate"].ConnectionString;
            cmd.Parameters.AddWithValue("@teamId", teamId);
            //
            string kq = null;
            SqlDataReader reader = null;
            //
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    kq = (reader.GetString(0));
                    
                }
            }
            finally
            {
                reader.Close();
                connection.Close();

            }
            return kq;
        }

        public int CheckAllHostConnected()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select convert(int,dbo.KiemTraConnection())";
            //
            int kq = 0;
            SqlDataReader reader = null;
            //
            try
            {
                reader =  cmd.ExecuteReader();
                if(reader.Read())
                {
                    kq = (int)(reader.GetInt32(0));
                    if(kq > 0)
                    {
                        reader.Close();
                        connection.Close();
                        return kq;
                    }
                }
            }
            finally
            {
                reader.Close();
                connection.Close();
                
            }
            return 9;
        }
        internal void InsertResultDetail(string teamId, string quesId, bool isCorrect)
        {
            try
            {
                //string hostName = ConfigurationManager.ConnectionStrings["hostName"].ConnectionString;
                //string programName = ConfigurationManager.ConnectionStrings["programName"].ConnectionString;
                //string teamID = ConfigurationManager.ConnectionStrings["teamID"].ConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = ConfigurationManager.ConnectionStrings["InsertResultRound1"].ConnectionString;
                cmd.Parameters.AddWithValue("@teamID", teamId);
                cmd.Parameters.AddWithValue("@questionId", quesId);
                cmd.Parameters.AddWithValue("@isCorrect", isCorrect?1:0);
                

                //Question question = null;
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    //string questionSTT = reader.GetInt32(0) + "";
                    //string questionID = reader.GetString(1);
                    //question = (new dbConnection()).GetQuestion(questionID);
                    //question.STT = questionSTT;
                }
                //reader.Close();
                connection.Close();
                //return question;
            }
            catch (Exception e)
            {
                //reader.Close();
                connection.Close();
                //return null;
            }
        }
        public string MakeTeamsPending()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "exec MakeTeamsPending";
            //
            //
            string kq = null;
            SqlDataReader reader = null;
            //
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    kq = (string)(reader.GetString(0));
                    if (kq != null)
                    {
                        reader.Close();
                        connection.Close();
                        return kq;
                    }
                }
            }
            finally
            {
                reader.Close();
                connection.Close();

            }
            return null;
        }

        public List<ResultDetail> GetAllResultDetail()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "exec GetResultDetail";
            //
            //
            //string kq = null;
            SqlDataReader reader = null;
            List<ResultDetail> resultDetails = new List<ResultDetail>();
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ResultDetail myResultDetail = new ResultDetail();
                    myResultDetail.ID = reader.GetString(0);
                    myResultDetail.Team = (new PointScreen.DAL()).GetTeam(reader.GetString(1));
                    myResultDetail.RoundNum = reader.GetInt32(7);
                    myResultDetail.QuestionNum = reader.GetInt32(8);
                    myResultDetail.Question = (new dbConnection()).GetQuestion(reader.GetString(2));
                    myResultDetail.Score = reader.GetInt32(3);
                    myResultDetail.Point = reader.GetInt32(9);
                    myResultDetail.IsCorrect = reader.GetBoolean(4);
                    //
                    resultDetails.Add(myResultDetail);
                }

            }
            finally
            {
                reader.Close();
                connection.Close();
            }

            return resultDetails;
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
                if(reader.Read())
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
