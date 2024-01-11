namespace WpfTemplates.ViewModels;

public class MessageViewModel : BaseViewModel
{
    private string? _message;
    public string? Message
    {
        get => _message;
        set
        {
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }

}
