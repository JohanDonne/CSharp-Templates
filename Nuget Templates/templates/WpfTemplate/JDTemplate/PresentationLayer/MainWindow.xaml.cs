using JDTemplate.Domain.Interfaces;
using System.Windows;

namespace JDTemplate.PresentationLayer;
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
        nametextBlock.Text = $"Hello World from {_logic.Info.Name} created on {_logic.Info.CreationDate}";
    }
}
