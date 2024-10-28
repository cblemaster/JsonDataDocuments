#region Usings
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
#endregion Usings

namespace JsonDataDocuments.Pages
{
    public partial class LookupFriendPage : Page, INotifyPropertyChanged
    {
        #region Private Fields
        private string _friendName = string.Empty;
        #endregion Private Fields

        #region Properties
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
        #endregion Properties

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };        
        #endregion Events

        #region Constructor
        public LookupFriendPage()
        {
            InitializeComponent();
            DataContext = this;
        }
        #endregion Constructor

        #region Methods
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameTextBox.Focus();
        }

        private void Submit() => throw new NotImplementedException();
        #endregion Methods
    }
}
