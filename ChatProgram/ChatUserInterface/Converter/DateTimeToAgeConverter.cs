using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ChatUserInterface
{
    public class DateTimeToAgeConverter : IValueConverter
    {
        public object DataTime { get; private set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {//TODO
           DateTime dateOfBirth = (DateTime)value;
            int years = (int)((DateTime.Now - dateOfBirth).TotalDays/365);
            return years;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
