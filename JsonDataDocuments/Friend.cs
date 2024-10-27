using System.Drawing;

namespace JsonDataDocuments;

internal class Friend
{
    internal int Id { get; set; }
    internal string Name { get; set; } = string.Empty;
    internal Color FavoriteColor { get; set; }
    string FavColorString => FavoriteColor.ToString();
}
