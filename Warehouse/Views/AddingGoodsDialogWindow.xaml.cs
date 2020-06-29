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
using System.Windows.Shapes;
using Warehouse.ViewModels;

namespace Warehouse.Views
{
    /// <summary>
    /// Логика взаимодействия для AddingGoodsDialogWindow.xaml
    /// </summary>
    public partial class AddingGoodsDialogWindow : Window
    {
        public AddingGoodsDialogWindow()
        {
            InitializeComponent();
            ComboBox comboBox = categorySelection;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            AddedCategory = selectedItem.Content.ToString();
        }

        //К рефакторингу: привести к MVVM
        private void AcceptAddingGoods_clicked(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            AddingGoodsDialogViewModel viewmodel = new AddingGoodsDialogViewModel();
            viewmodel.InsertToDataBase(AddedCategory, AddedGoodsName);
            MessageBox.Show("Товар добавлен, обновите страницу.");
        }

        public string AddedCategory { get; private set; }

        public string AddedGoodsName { get => goodsAddingTextBox.Text; }

        private void CategorySelection_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if (selectedItem.Content != null)
            {
                AddedCategory = selectedItem.Content.ToString();
            }
        }
    }
}
