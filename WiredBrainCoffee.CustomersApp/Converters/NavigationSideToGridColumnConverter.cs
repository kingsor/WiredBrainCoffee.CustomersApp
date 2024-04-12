using System;
using System.Globalization;
using System.Windows.Data;
using WiredBrainCoffee.CustomersApp.ViewModels;

namespace WiredBrainCoffee.CustomersApp.Converters
{
    public class NavigationSideToGridColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var navigationSide = (NavigationSide)value;

            return navigationSide == NavigationSide.Left ? 0 : 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
