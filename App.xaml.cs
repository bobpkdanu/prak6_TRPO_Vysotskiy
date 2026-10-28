using System.Windows;

namespace prak6_Vysotskiy;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        ThemeManager.ApplySaved();
    }
}
