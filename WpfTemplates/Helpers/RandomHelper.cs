namespace WpfTemplates.Helpers;

public static class RandomHelper
{
    private static readonly Random _getRandom = new();

    public static int GetRandomNumber(int min, int max)
    {
        lock (_getRandom) // synchronize
        {
            return _getRandom.Next(min, max);
        }
    }
}
