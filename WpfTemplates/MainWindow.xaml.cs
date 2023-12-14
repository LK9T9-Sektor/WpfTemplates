using System.Windows;
using WpfTemplates.Views;

namespace WpfTemplates;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GroupBoxCollection_Click(object sender, RoutedEventArgs e)
    {
        var window = new GroupBoxCollection();
        window.Show();
    }

    private void ListOfBtnsWithContent_Click(object sender, RoutedEventArgs e)
    {
        var window = new ListOfBtnsWithContent();
        window.Show();
    }

    private void SingleItemSelectFromList_Click(object sender, RoutedEventArgs e)
    {
        var window = new SingleItemSelectFromList();
        window.Show();
    }

    private void VerticalList_Click(object sender, RoutedEventArgs e)
    {
        var window = new VerticalList();
        window.Show();
    }

    private void VerticalScrollWithContent_Click(object sender, RoutedEventArgs e)
    {
        var window = new VerticalScrollWithContent();
        window.Show();
    }

}
