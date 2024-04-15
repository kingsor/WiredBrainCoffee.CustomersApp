// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;

namespace WiredBrainCoffee.CustomersApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly CustomersViewModel _customersViewModel;
        private ViewModelBase? _selectedViewModel;

        public MainViewModel(CustomersViewModel customersViewModel)
        {
            _customersViewModel = customersViewModel;
            SelectedViewModel = _customersViewModel;
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

        public override async Task LoadAsync()
        {
            if(SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }

    }
}
