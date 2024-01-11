using System.Windows.Input;

namespace WpfTemplates.Commands;

public class OnlyExecuteCommand : ICommand
{
    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    public OnlyExecuteCommand(Action execute, Func<bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public event EventHandler? CanExecuteChanged = null;

    public bool CanExecute() => _canExecute is null || _canExecute();

    public void Execute() => _execute?.Invoke();

    bool ICommand.CanExecute(object? parameter) => CanExecute();

    void ICommand.Execute(object? parameter) => Execute();

}
