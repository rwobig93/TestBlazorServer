using MudBlazor;

namespace TestBlazorServerApp.Pages;

public partial class Counter
{
    private int _currentCount = 0;
    private Color _iconColor = Color.Primary;

    private void IncrementClick()
    {
        _currentCount++;
        _iconColor = GetRandomColor();
    }

    private static Color GetRandomColor()
    {
        var colors = Enum.GetValues<Color>();
        var random = new Random();
        return (Color)colors.GetValue(random.Next(colors.Length))!;
    }
}