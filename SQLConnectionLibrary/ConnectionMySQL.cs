using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLConnectionLibrary
{
    public class ConnectionMySQL
    {
        #region подключение
        MySqlConnection connection = new MySqlConnection("server=www.db4free.net;port=3306;username=undeadwindangel;password=Bravo930804;database=undeadwindbd;");
        #endregion
        #region Методы работы с подключением
        public void openConnection()
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        
        #endregion
    }
}
