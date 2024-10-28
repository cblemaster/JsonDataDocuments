using JsonDataDocuments.Models;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace JsonDataDocuments.UserControls;

public partial class FriendDetails : UserControl, INotifyPropertyChanged
{
    private string _friendName = string.Empty;
    private Color _favoriteColor;

    public string FriendName
    {
        get => _friendName;
        set
        {
            if (!value.Equals(_friendName))
            {
                _friendName = value;
                PropertyChanged!(this, new PropertyChangedEventArgs(nameof(FriendName)));
            }
        }
    }
    public Color FavoriteColor
    {
        get => _favoriteColor;
        set
        {
            if (!value.Equals(_favoriteColor))
            {
                _favoriteColor = value;
                PropertyChanged!(this, new PropertyChangedEventArgs(nameof(FavoriteColor)));
            }

        }
    }

    public event PropertyChangedEventHandler? PropertyChanged = delegate { };

    public FriendDetails() => InitializeComponent();

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
        //TODO >> pass in real data
        var friend = new Friend() { Id = 1, Name = "brian", FavoriteColor = Color.Blue };
        FriendName = friend.Name;
        FavoriteColor = friend.FavoriteColor;
    }
}
