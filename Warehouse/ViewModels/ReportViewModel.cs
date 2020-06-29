using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Warehouse.Models;

namespace Warehouse.ViewModels
{
    public class ReportViewModel : MainViewModel
    {
        public class GoodsToReport
        {
            private string _id;
            private string _category;
            private string _goodName;
            public string Id { get => _id; set => _id = value; }
            public string Category { get => _category; set => _category = value; }
            public string GoodName { get => _goodName; set => _goodName = value; }
        }

        public DataTable AcceptedGoodsDataDB = MainModel.Select("SELECT [dbo].[Goods].[id], [dbo].[Categories].[Category], [dbo].[Goods].[Name]" +
                                                         "FROM [dbo].[Goods]" +
                                                         "JOIN [dbo].[Categories]" +
                                                         "ON [dbo].[Goods].[Category_id] = [dbo].[Categories].[id]" +
                                                         "WHERE [dbo].[Goods].[Status_id] = 1");

        public void LoadAcceptedGoodsToList(DataTable data, ListView list)
        {
            for (int i = 0; i < data.Rows.Count; i++) // перебираем данные
            {
                GoodsToReport dataGoods = new GoodsToReport() // создаём экземпляр класса
                {
                    Id = data.Rows[i][0].ToString(), // указываем id
                    Category = data.Rows[i][1].ToString(), // указываем категорию
                    GoodName = data.Rows[i][2].ToString() // указываем название товара
                };
                list.Items.Add(dataGoods); // выводим строку в список
            }
        }
    }
}
