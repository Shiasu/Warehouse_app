using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Warehouse.ViewModels;

namespace Warehouse.Views
{
    /// <summary>
    /// Логика взаимодействия для OnWarehouseView.xaml
    /// </summary>
    public partial class OnWarehouseView : UserControl
    {
        public OnWarehouseView()
        {
            InitializeComponent();
            OnWarehouseViewModel OnWarehouseData = new OnWarehouseViewModel();
            OnWarehouseData.LoadOnWarehouseGoodsToList(OnWarehouseData.OnWarehouseGoodsDataDB, onWarehouseList);
        }

        private void SellContext_clicked(object sender, RoutedEventArgs e)
        {
            /*MenuItem menuItem = (MenuItem)e.Source;
            string block = menuItem.ToString();
            MessageBox.Show(block);*/
        }
    }
}
