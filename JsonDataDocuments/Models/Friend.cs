using System.Drawing;

namespace JsonDataDocuments.Models;

public class Friend
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Color FavoriteColor { get; set; }
    
    public override string ToString() => $"Id: {Id}|Name: {Name}|Favorite Color: {FavoriteColor}";
}
