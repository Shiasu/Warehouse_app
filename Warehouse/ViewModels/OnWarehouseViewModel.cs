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
    public class OnWarehouseViewModel : MainViewModel
    {
        public DataTable OnWarehouseGoodsDataDB = MainModel.Select("SELECT [dbo].[Goods].[id], [dbo].[Categories].[Category], [dbo].[Goods].[Name]" +
                                                         "FROM [dbo].[Goods]" +
                                                         "JOIN [dbo].[Categories]" +
                                                         "ON [dbo].[Goods].[Category_id] = [dbo].[Categories].[id]" +
                                                         "WHERE [dbo].[Goods].[Status_id] = 2");

        public void LoadOnWarehouseGoodsToList(DataTable data, ListView list)
        {
            for (int i = 0; i < data.Rows.Count; i++) // перебираем данные
            {
                MainModel.Goods dataOnWarehouseGoods = new MainModel.Goods() // создаём экземпляр класса
                {
                    Id = data.Rows[i][0].ToString(), // указываем id
                    Category = data.Rows[i][1].ToString(), // указываем категорию
                    GoodName = data.Rows[i][2].ToString() // указываем название товара
                };
                list.Items.Add(dataOnWarehouseGoods); // выводим строку в список
            }
        }
    }
}
