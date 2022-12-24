using Template.LogicLayer;
using Template.PresentationLayer;
using System.Windows;
using Template.DataAccessLayer;
using Template.Domain.Interfaces;
using System.Globalization;
using System.Windows.Markup;

namespace Template.AppRoot;
/// <summary>
/// Composition root for App
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // Change Language & culture for WPF FrameworkEelements form en-US to the local Windows Settings.
        FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
           new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
        base.OnStartup(e);

        IData data = new Data();
        ILogic logic = new Logic(data);
        new MainWindow(logic).Show();
    }
}
