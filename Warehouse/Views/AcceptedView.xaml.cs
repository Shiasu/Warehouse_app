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
            AcceptedViewModel AcData = new AcceptedViewModel();
            AcData.LoadAcceptedGoodsToList(AcData.AcceptedGoodsDataDB, acceptedList);
        }
    }
}
