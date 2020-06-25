using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class MainModel
    {
        public static DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            //Для подключения к локальной базе данных необходимо изменить в sqlConnection server и Database на свои
            SqlConnection sqlConnection = new SqlConnection("server=ТОПЧИК-ПК\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=Warehouse_DB;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
