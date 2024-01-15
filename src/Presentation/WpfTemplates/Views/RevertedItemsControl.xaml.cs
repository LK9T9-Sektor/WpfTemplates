using System.Collections.ObjectModel;
using System.Windows;
using WpfTemplates.Shared.Models;
using WpfTemplates.Shared.Services;

namespace WpfTemplates.Views;

public partial class RevertedItemsControl : Window
{
    private readonly StringGeneratorService _stringGeneratorService;
    public ObservableCollection<Item> ItemsList { get; set; } = [];

    public RevertedItemsControl()
    {
        InitializeComponent();
        DataContext = this;

        ItemsList.Add(new("1", "2"));

        _stringGeneratorService = new(Add);
        _stringGeneratorService.Start();
    }

    private void Add(string text)
    {
        Dispatcher.BeginInvoke(delegate ()
        {
            ItemsList.Add(new(text, DateTime.Now.ToString()));
            //ItemsList.Insert(0, new(text, DateTime.Now.ToString()));
        });
    }

}
