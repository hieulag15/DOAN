using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    internal class MY_DB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HIEULAG\THANHHIEU;Initial Catalog=CUAHANG;Integrated Security=True");

        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }


        //open the connection
        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //close the connection
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
