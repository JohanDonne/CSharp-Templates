using Templates.Domain.Interfaces;

namespace Templates.PresentationLayer;
public partial class MainForm : Form
{

    private readonly ILogic _logic;
    public MainForm(ILogic logic)
    {
        _logic = logic;
        InitializeComponent();
        nameTextBox.Text = $"Hello World from {_logic.Info.Name} by {_logic.Info.Author}";

    }
}
