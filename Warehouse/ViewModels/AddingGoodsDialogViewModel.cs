using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;
using Warehouse.Views;

namespace Warehouse.ViewModels
{
    class AddingGoodsDialogViewModel : MainViewModel
    {
        public void InsertToDataBase(string category, string name)
        {
            int categoryId = 0;
            switch (category)
            {
                case "Видеокарты":
                    categoryId = 1;
                    break;
                case "Процессоры":
                    categoryId = 2;
                    break;
                case "Оперативная память":
                    categoryId = 3;
                    break;
                case "Жесткие диски":
                    categoryId = 4;
                    break;
            }
            MainModel.InsertOrUpdate($"INSERT INTO [dbo].[Goods] (Category_id, Name, Status_id) VALUES ({categoryId}, '{name}', 1)");
        }
    }
}
