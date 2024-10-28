using System.Windows.Controls;

namespace JsonDataDocuments.UserControls
{
    /// <summary>
    /// Interaction logic for SubmitButton.xaml
    /// </summary>
    public partial class SubmitButton : UserControl
    {
        public SubmitButton()
        {
            InitializeComponent();
        }
    }
}

//TODO >> This control should not specify any content for the button -- that might be a bindable property?

//      For example - the login page will have two (2) big round buttons
//      And other pages will have smaller rectangular form submit buttons
//      Also need to consider 'is enabled' data bindings

