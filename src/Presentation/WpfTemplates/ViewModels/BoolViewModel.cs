using System.IO;
using System.Reflection;

namespace WpfTemplates.ViewModels;

public class BoolViewModel : BaseViewModel
{
    public BoolViewModel()
    {
        SetUpdateDate(false);
    }

    private void SetUpdateDate(bool isNetFramework)
    {
        if (isNetFramework)
        {
            // .NetFramework uses exe
            var filePath = Assembly.GetExecutingAssembly().Location;
            var fileInfo = new FileInfo(filePath);
            UpdatedDate = fileInfo.CreationTime;
        }
        else
        {
            var filePath = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location)
                ?? Directory.GetCurrentDirectory();
            var fileInfo = new FileInfo(filePath);

            // .Net uses .dll, so if needed, add filename.exe 
            //var fileInfo = new FileInfo($"{filePath}\\WpfTemplates.exe");

            UpdatedDate = fileInfo.CreationTime;
        }
    }


    private bool _isTrue = true;
    public bool IsTrue
    {
        get => _isTrue;
        set
        {
            _isTrue = value;
            OnPropertyChanged(nameof(IsTrue));
        }
    }

    private string _message = "Вход";
    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }

    private DateTime _updatedDate;
    public DateTime UpdatedDate
    {
        get => _updatedDate;
        set
        {
            _updatedDate = value;
            OnPropertyChanged(nameof(Message));
        }
    }

}
