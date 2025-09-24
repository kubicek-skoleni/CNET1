using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("cs-CZ");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("cs-CZ");
        }
    }

}
