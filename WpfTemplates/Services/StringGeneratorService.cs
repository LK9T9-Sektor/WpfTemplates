using WpfTemplates.Helpers;

namespace WpfTemplates.Services;

public class StringGeneratorService
{
    private readonly Action<string> _onCreated;
    private bool _started = false;
    private readonly double _timerInterval = 5;
    private Timer? _timer = null;

    public StringGeneratorService(Action<string> onCreated)
    {
        _onCreated = onCreated;
    }

    public void Start()
    {
        if (_started == false)
        {
            _timer = new Timer(Callback, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(_timerInterval));
            _started = true;
        }
    }

    private void Callback(object? state)
    {
        var randomValue = RandomHelper.GetRandomNumber(0, 999);

        _onCreated?.Invoke(randomValue.ToString());
    }

}
