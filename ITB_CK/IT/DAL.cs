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

        public bool CheckAllHostConnected()
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
                        return true;
                    }
                }
            }
            finally
            {
                reader.Close();
                connection.Close();
                
            }
            return false;
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
