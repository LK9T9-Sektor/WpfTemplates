using System.Collections.ObjectModel;
using System.Windows;
using WpfTemplates.Shared.Models;
using WpfTemplates.Shared.Services;

namespace WpfTemplates.Views;

public partial class AnimationVerticalInsertItem : Window
{
    private readonly StringGeneratorService _stringGeneratorService;
    public ObservableCollection<Item> ItemsList { get; set; } = [];

    public AnimationVerticalInsertItem()
    {
        InitializeComponent();
        DataContext = this;

        _stringGeneratorService = new(Add);
        _stringGeneratorService.Start();
    }

    private void Add(string text)
    {
        Dispatcher.BeginInvoke(delegate ()
        {
            ItemsList.Add(new(text, DateTime.Now.ToString()));
        });
    }

}
