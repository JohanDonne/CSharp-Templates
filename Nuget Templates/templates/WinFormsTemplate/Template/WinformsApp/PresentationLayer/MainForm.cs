using Template.Domain.Interfaces;

namespace Template.PresentationLayer;
public partial class MainForm : Form
{

    private readonly ILogic _logic;
    public MainForm(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        nameTextBox.Text = $"Hello World from {_logic.Info.Name} created on {_logic.Info.CreationDate}";

    }
}
