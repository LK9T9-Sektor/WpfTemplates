﻿using System.Collections.ObjectModel;
using System.Windows;
using WpfTemplates.Models;
using WpfTemplates.Services;

namespace WpfTemplates.Views;

public partial class AnimationInsertItem : Window
{
    private readonly StringGeneratorService _stringGeneratorService;
    public ObservableCollection<Item> ItemsList { get; set; } = [];

    public AnimationInsertItem()
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
        });
    }

}
