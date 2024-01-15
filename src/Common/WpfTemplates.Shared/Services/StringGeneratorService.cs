using WpfTemplates.Shared.Helpers;

namespace WpfTemplates.Shared.Services;

public class StringGeneratorService
{
    private readonly Action<string> _onCreated;
    private readonly double _timerInterval = 5;
    private Timer? _timer = null;

    public StringGeneratorService(Action<string> onCreated)
    {
        _onCreated = onCreated;
    }

    public void Start()
    {
        if (_timer == null)
        {
            _timer = new Timer(Callback, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(_timerInterval));
        }
    }

    public void Stop()
    {
        _timer?.Dispose();
    }

    private void Callback(object? state)
    {
        var randomValue = RandomHelper.GetRandomNumber(0, 999);

        _onCreated?.Invoke(randomValue.ToString());
    }

}
