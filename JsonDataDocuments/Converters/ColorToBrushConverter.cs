using System.Globalization;
using System.Windows.Data;

namespace JsonDataDocuments.Converters;

internal class ColorToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is System.Drawing.Color c)
        {
            return new System.Windows.Media.SolidColorBrush(new System.Windows.Media.Color() { A = c.A, B = c.B, G = c.G, R = c.R });
        }
        return value;
    }
    
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}
