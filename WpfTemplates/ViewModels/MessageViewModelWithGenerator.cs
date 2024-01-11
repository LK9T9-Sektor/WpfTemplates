using System.Windows.Input;
using WpfTemplates.Commands;
using WpfTemplates.Services;

namespace WpfTemplates.ViewModels;

public class MessageViewModelWithGenerator : MessageViewModel
{
    private readonly StringGeneratorService _stringGeneratorService;

    public MessageViewModelWithGenerator()
    {
        _stringGeneratorService = new(Add);
        _stringGeneratorService.Start();

        CloseCommand = new OnlyExecuteCommand(CloseCommandExecute);
    }

    public ICommand CloseCommand { get; }

    private void CloseCommandExecute()
    {
        _stringGeneratorService.Stop();
    }

    private void Add(string text)
    {
        Message = text;
    }

}
