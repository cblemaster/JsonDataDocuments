using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace JsonDataDocuments.Pages
{
    public partial class LookupFriendPage : Page, INotifyPropertyChanged
    {
        private string _friendName = string.Empty;

        public string FriendName
        {
            get => _friendName;
            set
            {
                if (!value.Equals(_friendName))
                _friendName = value;
                PropertyChanged!(this, new PropertyChangedEventArgs(nameof(FriendName)));
            }
        }        

        public event PropertyChangedEventHandler? PropertyChanged = delegate { };        

        public LookupFriendPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) => NameTextBox.Focus();

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Submit button clicked!!!";
            string caption = "Submit button";
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxImage icon = MessageBoxImage.Information;
            MessageBoxResult result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);

            //TODO: Nav to content
        }
    }
}
