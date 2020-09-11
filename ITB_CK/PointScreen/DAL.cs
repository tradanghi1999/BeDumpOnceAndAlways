using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data.SqlClient;
using System.Data;

namespace PointScreen
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
                                    "@programName = '"+programName+"'," +
                                    "@hostName = '"+hostName+"';";
                if(cmd.ExecuteNonQuery() <= 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Model.Team> GetPoint(int nam)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "exec GetPoint @nam='" + nam + "'";
                cmd.Connection = connection;
                //
                List<Model.Team> teamS = new List<Model.Team>();
                //
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string teamID = reader.GetString(0);
                    string teamName = reader.GetString(1);
                    int score = reader.GetInt32(2);
                    string round1State = reader.GetString(3);
                    string round2State = reader.GetString(4);
                    string round3State = reader.GetString(5);
                    DateTime dateTime = reader.GetDateTime(6);
                    //
                    Model.Team team = new Model.Team();
                    team.ID = teamID;
                    team.Name = teamName;
                    team.Round1State = round1State;
                    team.Round2State = round2State;
                    team.Round3State = round3State;
                    team.LastModified = dateTime;
                    //
                    teamS.Add(team);
                }
                //
                reader.Close();
                connection.Close();
                return teamS;
            }
            catch
            {
                reader.Close();
                connection.Close();
                return null;
            }
            
        }

    }
}
