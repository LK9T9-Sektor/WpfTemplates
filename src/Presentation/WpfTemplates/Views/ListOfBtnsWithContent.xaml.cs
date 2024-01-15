using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WpfTemplates.Views;

public partial class ListOfBtnsWithContent : Window
{
    public ListOfBtnsWithContent()
    {
        InitializeComponent();

        DataContext = new List<ScreenRequest>
        {
            new ScreenRequest() { ActionDescription = "Click Me!", Content = "1" },
            new ScreenRequest() { ActionDescription = "Click Me Too!", Content = "2" },
            new ScreenRequest() { ActionDescription = "Click Me Again!!", Content = "3" },
        };

    }

}

public class ListOfBtnsWithContentViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    public ObservableCollection<ScreenRequest> ScreenRequests { get; set; } = new();
    public ScreenRequest SelectedRequests { get; set; } = new();

}

public class ScreenRequest : INotifyPropertyChanged
{
    public Command SomeAction { get; set; }

    private string _actionDescription;
    public string ActionDescription
    {
        get { return _actionDescription; }
        set
        {
            _actionDescription = value;
            NotifyPropertyChanged("ActionDescription");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void NotifyPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    public ScreenRequest()
    {
        SomeAction = new Command(ExecuteSomeAction) { IsEnabled = true };
    }

    private string _content;
    public string Content
    {
        get { return _content; }
        set
        {
            _content = value;
            NotifyPropertyChanged("Content");
        }
    }

    //public SomeProperty YourProperty { get; set; }

    private void ExecuteSomeAction()
    {
        //Place your custom logic here based on YourProperty
        ActionDescription = "Clicked!!";
        Content = "Some Details";
    }

}

public class Command : ICommand
{
    public Action Action { get; set; }

    public void Execute(object parameter)
    {
        if (Action != null)
            Action();
    }

    public bool CanExecute(object parameter)
    {
        return IsEnabled;
    }

    private bool _isEnabled;
    public bool IsEnabled
    {
        get { return _isEnabled; }
        set
        {
            _isEnabled = value;
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }
    }

    public event EventHandler CanExecuteChanged;

    public Command(Action action)
    {
        Action = action;
    }

}
