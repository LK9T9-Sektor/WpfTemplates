using System.Windows;
using WpfTemplates.MVVMExamples;
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

    private void RevertedItemsControl_Click(object sender, RoutedEventArgs e)
    {
        var window = new RevertedItemsControl();
        window.Show();
    }

    private void AnimationVerticalInsertItem_Click(object sender, RoutedEventArgs e)
    {
        var window = new AnimationVerticalInsertItem();
        window.Show();
    }

    private void AnimationInsertItem_Click(object sender, RoutedEventArgs e)
    {
        var window = new AnimationInsertItem();
        window.Show();
    }

    private void MessageBoxShowOnValueUpdate_Click(object sender, RoutedEventArgs e)
    {
        var window = new MessageBoxShowOnValueUpdate();
        window.Show();
    }

    private void BindingsToViewModel_Click(object sender, RoutedEventArgs e)
    {
        var window = new BindingsToViewModel();
        window.Show();
    }
        

}
