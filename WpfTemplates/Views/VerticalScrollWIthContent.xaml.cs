using System.Windows;

namespace WpfTemplates.Views;

public partial class VerticalScrollWithContent : Window
{
    public VerticalScrollWithContent()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
