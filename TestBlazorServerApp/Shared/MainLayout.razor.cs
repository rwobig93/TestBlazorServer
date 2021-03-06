using System.Reflection;
using MudBlazor;
using TestBlazorServerApp.Settings;

namespace TestBlazorServerApp.Shared;

public partial class MainLayout
{
    private static string ApplicationName => Assembly.GetExecutingAssembly().GetName().Name ?? "TestBlazorServerApp";
    private bool _drawerOpen = true;
    private MudTheme _selectedTheme = AppThemes.DarkTheme.Theme;

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    private void ChangeTheme(MudTheme theme)
    {
        _selectedTheme = theme;
    }
    
    private static List<AppTheme> GetAvailableThemes()
    {
        var fields = typeof(AppThemes)
            .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

        return (from fi in fields select fi.GetValue(null)
            into propertyValue
            where propertyValue is not null select (AppTheme)propertyValue).ToList()!;
    }
}