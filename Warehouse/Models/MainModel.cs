using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Models
{
    public class MainModel
    {
        public class Goods
        {
            private string _id;
            private string _category;
            private string _goodName;
            private string _date;
            public string Id { get => _id; set => _id = value; }
            public string Category { get => _category; set => _category = value; }
            public string GoodName { get => _goodName; set => _goodName = value; }

            public string Date { get => _date; set => _date = value; }
        }

        public static DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            //Для подключения к локальной базе данных необходимо изменить в sqlConnection server и Database на свои
            SqlConnection sqlConnection = new SqlConnection("server=SHIASU-PC\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=Warehouse_DB;");
            try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = selectSQL;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка работы с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Dispose();
                }
                return dataTable;
            
        }

        public static void InsertOrUpdate(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            //Для подключения к локальной базе данных необходимо изменить в sqlConnection server и Database на свои
            SqlConnection sqlConnection = new SqlConnection("server=SHIASU-PC\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=Warehouse_DB;");
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = selectSQL;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка работы с базой данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Dispose();
            }
        }
    }
}
