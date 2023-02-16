using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MEOsys
{
    class Database
    {


        private MySqlCommand cmd;
        private MySqlConnection connection;
        public Database()
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=meosys;");
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
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

        public Boolean insertData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            if (cmd.ExecuteNonQuery() == 1)
            {
                closeConnection();
                return true;
            }
            closeConnection();
            return false;
        }


        public DataTable getData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            closeConnection();
            return table;
        }


        public Boolean updateData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true;
            }
            return false;
        }

        public Boolean deleteData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                return true;
            }

            return false;
        }

        public MySqlDataReader editData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            MySqlDataReader dr = cmd.ExecuteReader();
            
            return dr;
        }

        public string getOneData(string command)
        {
            openConnection();
            cmd.CommandText = command;
            string ret = cmd.ExecuteScalar().ToString();
            closeConnection();
            return ret;
        }
        public MySqlDataReader getUserLevel(string username, string password)
        {
            openConnection();
            cmd.CommandText = "select * from users where username='" + username + "' and password='" + password + "'";
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
