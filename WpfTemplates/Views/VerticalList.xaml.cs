using System.Windows;

namespace WpfTemplates.Views;

public partial class VerticalList : Window
{
    public VerticalList()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}

public class Item
{
    public Item(string title, string title2)
    {
        Title = title;
        Title2 = title2;
    }

    public string Title { get; set; }
    public string Title2 { get; set; }
}

public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        Titles = new List<Item>()
         {
            new Item("Slide #1", "Title2 #1"),
            new Item("Slide #2", "Title2 #2"),
            new Item("Slide #3", "Title2 #3"),
            new Item("Slide #4", "Title2 #4"),
            new Item("Slide #5", "Title2 #5"),
            new Item("Slide #6", "Title2 #6"),
            new Item("Slide #7", "Title2 #7"),
            new Item("Slide #8", "Title2 #8"),
         };
    }

    public List<Item> Titles { get; set; }
}

