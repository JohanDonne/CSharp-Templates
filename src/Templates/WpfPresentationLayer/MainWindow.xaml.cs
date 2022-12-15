using Templates.Domain.Interfaces;
using System.Windows;

namespace Templates.PresentationLayer;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ILogic _logic;

    public MainWindow(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        nametextBlock.Text = $"Hello World from {_logic.Info.Name} by {_logic.Info.Author}";
    }
}
