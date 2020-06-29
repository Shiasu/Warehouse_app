using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для AcceptedView.xaml
    /// </summary>
    public partial class AcceptedView : UserControl
    {
        public AcceptedView()
        {
            InitializeComponent();
            AcceptedViewModel AcceptData = new AcceptedViewModel();
            AcceptData.LoadAcceptedGoodsToList(AcceptData.AcceptedGoodsDataDB, acceptedList);
        }

        //В дальнейшем все обработчики будут преобразованы в команды с помощью интерфейса комманд ICommand
        //дабы реализовать MVVM более правильно
        private void AddingGoods_clicked(object sender, RoutedEventArgs e)
        {
            AddingGoodsDialogWindow dialogWindow = new AddingGoodsDialogWindow();
            if (dialogWindow.ShowDialog() == true)
            {

            }
            else
            {

            }
        }
    }
}
