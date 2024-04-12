﻿using System.Windows;
using System.Windows.Controls;
using WiredBrainCoffee.CustomersApp.Data;
using WiredBrainCoffee.CustomersApp.ViewModels;

namespace WiredBrainCoffee.CustomersApp.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        private CustomersViewModel _viewModel;

        public CustomersView()
        {
            InitializeComponent();
            _viewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _viewModel;
            Loaded += CustomersView_Loaded;
        }

        private async void CustomersView_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            //var column = (int)customerListGrid.GetValue(Grid.ColumnProperty);

            //var newColumn = column == 0 ? 2 : 0;
            //customerListGrid.SetValue(Grid.ColumnProperty, newColumn);

            var column = Grid.GetColumn(customerListGrid);

            var newColumn = column == 0 ? 2 : 0;
            Grid.SetColumn(customerListGrid, newColumn);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Add();
        }
    }
}
