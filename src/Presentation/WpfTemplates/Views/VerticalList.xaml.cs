using System.Windows;
using WpfTemplates.Shared.Models;

namespace WpfTemplates.Views;

public partial class VerticalList : Window
{
    public VerticalList()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}

public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        Titles = new List<Item>()
        {
            new Item("Title #1", "Text #1"),
            new Item("Title #2", "Text #2"),
            new Item("Title #3", "Text #3"),
            new Item("Title #4", "Text #4"),
            new Item("Title #5", "Text #5"),
            new Item("Title #6", "Text #6"),
            new Item("Title #7", "Text #7"),
            new Item("Title #8", "Text #8"),
         };
    }

    public List<Item> Titles { get; set; }
}

