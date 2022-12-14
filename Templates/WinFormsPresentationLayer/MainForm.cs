using Domain.Interfaces;

namespace PresentationLayer;
public partial class MainForm : Form
{

    private readonly ILogic _logic;
    public MainForm(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        nameTextBox.Text = $"Hello World from {_logic.AppName}";

    }
}
