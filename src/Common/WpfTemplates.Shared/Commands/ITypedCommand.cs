using System.Windows.Input;

namespace WpfTemplates.Shared.Commands;

public interface ITypedCommand<in T> : ICommand
{
    bool CanExecute(T? parameter);

    void Execute(T? parameter);

}
