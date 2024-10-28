using System.Windows;
using System.Windows.Controls;

namespace JsonDataDocuments.Pages;

public partial class LoginPage : Page
{
    public LoginPage() => InitializeComponent();

    private void YesButton_Click(object sender, RoutedEventArgs e)
    {
        string messageBoxText = "Yes button clicked!!!";
        string caption = "Yes button";
        MessageBoxButton button = MessageBoxButton.OK;
        MessageBoxImage icon = MessageBoxImage.Information;
        MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        
        //TODO => Nav to lookup friend
    }

    private void NoButton_Click(object sender, RoutedEventArgs e)
    {
        string messageBoxText = "No button clicked!!!";
        string caption = "No button";
        MessageBoxButton button = MessageBoxButton.OK;
        MessageBoxImage icon = MessageBoxImage.Information;
        MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        
        //TODO => Nav to create friend
    }
}
