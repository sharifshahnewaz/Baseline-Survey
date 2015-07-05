using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BackEnd
{
    public class Database
    {
        public SqlConnection sqlcon;
        public SqlCommand sql;
        public SqlDataReader reader;
        string ConnectionString;

        public void Execute(String query)
        {
            //string s = "Data Source=192.168.90.199;Initial Catalog=baseline;User ID = HP;Password = rubel;";
            string s = ConnectionString;
            //string s = "Data Source=192.168.90.199;Initial Catalog=baseline;User ID = sa;Password = ";
            sqlcon = new SqlConnection(s);
            try
            {
                sqlcon.Open();
                sql = new SqlCommand(query, sqlcon);
            }
            catch (Exception e)
            {
                MessageBox.Show(" Sorry. You can not connect to server.Check your connection with server.");
            }
        }


        public Database(string Connection)
        {

            ConnectionString = Connection;



        }
        public Database()
        {
            ConnectionString = "Data Source=(LOCAL);Initial Catalog=baseline;User ID = sa;Password = ";
            //  sqlcon = new SqlConnection(ConnectionString);

        }

        public void ExecuteReader(String query)
        {
            try
            {
                Execute(query);
                reader = sql.ExecuteReader();
                reader.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());

            }
        }

        public String SelectSrting(String query)
        {
            String ret = null;
            try
            {
                ExecuteReader(query);
                ret = reader.GetString(0);
                sqlcon.Close();
            }
            catch (Exception e) { /*MessageBox.Show(e.ToString());*/ }
            return ret;
        }
        public String[] SelectSingleColumn(String query, String name)
        {
            DataSet ds = new DataSet();
            String[] ret = new String[1];
            int i = 0;
            try
            {

                Execute(query);
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                da.Fill(ds, name);
                DataTable dt = ds.Tables[name];
                ret = new String[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    ret[i++] = row[0].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return ret;
        }
        public String[,] SelectColumns(String query, String name)
        {
            DataSet ds = new DataSet();
            String[,] ret = new String[40, 40];
            int i = 0;
            int j = 0;
            try
            {

                Execute(query);
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                da.Fill(ds, name);
                DataTable dt = ds.Tables[name];
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        ret[i, j] = row[column].ToString();
                        j++;
                    }
                    j = 0;
                    i++;

                    // ret[i++] = row[0].ToString();
                }
                sqlcon.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
            return ret;
        }

        public int SelectInt(String query)
        {
            int ret = 0;
            try
            {
                ExecuteReader(query);
                ret = Convert.ToInt32(reader[0]);
            }
            catch (Exception e) { /*MessageBox.Show(e.ToString());*/ }
            sqlcon.Close();
            return ret;
        }

        public bool Insert(String query)
        {
            bool ret = false;
            //string s = "Data Source=192.168.90.254;Initial Catalog=baseline;User ID = HP;Password = rubel;";
            string s = ConnectionString;
            //string s = "Data Source=192.168.90.199;Initial Catalog=baseline;User ID = sa;Password = ";

            SqlConnection sqlcon;
            SqlCommand sql;
            sqlcon = new SqlConnection(ConnectionString);
            sqlcon.Open();
            sql = new SqlCommand(query, sqlcon);
            try
            {
                sql.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception e)
            {
                ret = false;
                MessageBox.Show(e.ToString());
            }
            sqlcon.Close();
            return ret;

        }
        public DataTable return_dataset(string query)
        {
            DataSet ds = new DataSet();
            DataTable d = new DataTable();
            try
            {


                Execute(query);
                SqlDataAdapter da = new SqlDataAdapter(query, sqlcon);
                da.Fill(d);


            }
            catch (Exception e)
            {
            }
            return d;

        }

    }
}
