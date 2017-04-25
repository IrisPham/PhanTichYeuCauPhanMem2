using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TopicManagement
{
    public class Database
    {
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        //Phan xu li ket noi sql
        public const String REGEX = ";;;";

        public static SqlConnection connection;
        public static bool connect(String url)
        {
            try
            {
                connection = new SqlConnection(url);
                connection.Open();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool disconnect()
        {
            try
            {
                connection.Close();
                connection.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Trả về giá trị 1 cột trong database
        public static List<String> getSingelData(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            List<String> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr.GetString(0));
            }
            dr.Close();
            return list;
        }

        public static bool InsertData(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch
            {
                cmd.Dispose();
                return false;
            }
        }

        public static bool updateData(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch
            {
                cmd.Dispose();
                return false;
            }
        }

        public static DataTable fillDataToTable(String sql)
        {
            SqlDataAdapter data = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            data.Fill(table);
            return table;
        }
    }
}
