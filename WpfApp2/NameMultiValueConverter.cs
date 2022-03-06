using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp2
{
    public class NameMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {//source to target
            string firstName = "";
            foreach (object item in values)
            {
                firstName += " " + item;
            }
            return firstName;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {//target to source
            string str = (string)value; 
            string[] arr = str.Split(' ');
            return arr;
        }
    }
}
