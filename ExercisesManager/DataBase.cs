using System.Data.SqlClient;

namespace ExercisesManager
{
    internal class DataBase
    {
        private readonly SqlConnection _sqlConnection = new SqlConnection(@"DATA SOURCE = AP-JJQOKZ7FBRKV\SQLEXPRESS; 
                                                        INITIAL CATALOG = Exercise_DB; INTEGRATED SECURITY = True  ");

        public void OpenConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_sqlConnection.State == System.Data.ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return _sqlConnection;
        }
    }
}

