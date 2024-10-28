using System.Globalization;
using System.Windows.Controls;

namespace JsonDataDocuments.Validation;

public class StringLengthRule : ValidationRule
{
    public int Min { get; set; }
    public int Max { get; set; }
    public string PropName { get; set; } = string.Empty;

    public StringLengthRule() { }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        string s = (string)value;
        return (s.Length < Min) || (s.Length > Max)
            ? new ValidationResult(false, $"{PropName} must be between {Min} and {Max} characters.")
            : ValidationResult.ValidResult;
    }
}
