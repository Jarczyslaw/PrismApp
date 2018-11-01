using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PrismApp.Modules.Commands
{
    public class StateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var state = value as bool?;

            var result = string.Empty;
            if (state == null)
                result = "Undefined";
            else
                result = state.Value ? "Done!" : "Working...";
            return "State: " + result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
