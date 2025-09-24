using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesManager
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = AP-JJQOKZ7FBRKV\SQLEXPRESS; 
                                                        Initial Catalog = Exercise_DB; Integrated Security = True  ");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}

