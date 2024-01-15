using System.Windows;
using WpfTemplates.ViewModels;

namespace WpfTemplates.MVVMExamples;

public partial class BindingsToViewModel : Window
{
    private readonly MessageViewModel _messageModel = new();

    public BindingsToViewModel()
    {
        InitializeComponent();
        DataContext = _messageModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        _messageModel.Message = "TEST";
    }

    private void SaveInput_Click(object sender, RoutedEventArgs e)
    {
        _messageModel.Message = MessageInput.Text;
    }

}
