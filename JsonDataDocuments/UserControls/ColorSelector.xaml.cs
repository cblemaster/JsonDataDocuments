using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace JsonDataDocuments.UserControls;

public partial class ColorSelector : UserControl, INotifyPropertyChanged
{
    private Color _selectedColor;

    public Color SelectedColor
    {
        get => _selectedColor;
        set
        {
            if (!value.Equals(_selectedColor))
            {
                _selectedColor = value;
                PropertyChanged!(this, new PropertyChangedEventArgs(nameof(SelectedColor)));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    public ColorSelector() => InitializeComponent();

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
        if (AllColorsComboBox.ItemsSource.Cast<Color>().FirstOrDefault() is Color c)
        {
            SelectedColor = c;
        }
    }

    private void AllColorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        // TODO >> Replace with selection chanaged logic, if any

        string messageBoxText = $"Selected color changed!!! Selected color is now {SelectedColor}";
        string caption = "Color selector";
        MessageBoxButton button = MessageBoxButton.OK;
        MessageBoxImage icon = MessageBoxImage.Information;
        MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
    }
}
