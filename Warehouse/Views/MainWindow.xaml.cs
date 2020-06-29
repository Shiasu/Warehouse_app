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
using Warehouse.Views;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //В дальнейшем все обработчики будут преобразованы в команды с помощью интерфейса комманд ICommand
        //дабы реализовать MVVM более правильно
        private void AcceptedView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new AcceptedViewModel();
        }

        private void OnWarehouseView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new OnWarehouseViewModel();
        }

        private void SoldView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new SoldViewModel();
        }

        private void ReportView_Clicked(object sender, RoutedEventArgs e)
        {
            DataContext = new ReportViewModel();
        }
    }
}
