using System.Windows;
using System.Windows.Controls;
using WpfTemplates.ViewModels;

namespace WpfTemplates.Views;

public partial class MessageBoxShowOnValueUpdate : Window
{
    public MessageBoxShowOnValueUpdate()
    {
        InitializeComponent();
        DataContext = new MessageViewModelWithGenerator();
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        MessageBox.Show(TextBox_Value.Text);
    }

}
