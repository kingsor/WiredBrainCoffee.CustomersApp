// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Commands;

namespace WiredBrainCoffee.CustomersApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly CustomersViewModel _customersViewModel;
        private readonly ProductsViewModel _productsViewModel;
        private ViewModelBase? _selectedViewModel;

        public MainViewModel(CustomersViewModel customersViewModel, ProductsViewModel productsViewModel)
        {
            _customersViewModel = customersViewModel;
            _productsViewModel = productsViewModel;
            SelectedViewModel = _customersViewModel;
            SelectViewModelCommand = new DelegateCommand(SelectViewModel);
        }

        

        public ViewModelBase? SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }

        public CustomersViewModel CustomersViewModel => _customersViewModel;
        public ProductsViewModel ProductsViewModel => _productsViewModel;
        public DelegateCommand SelectViewModelCommand { get; }

        public override async Task LoadAsync()
        {
            if(SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }

        private async void SelectViewModel(object? parameter)
        {
            SelectedViewModel = parameter as ViewModelBase;
            await LoadAsync();
        }

    }
}
