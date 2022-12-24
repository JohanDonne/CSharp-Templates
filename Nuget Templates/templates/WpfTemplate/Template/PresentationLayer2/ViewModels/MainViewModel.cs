using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Template.Domain.Interfaces;

namespace Template.PresentationLayer.ViewModels;
public partial class MainViewModel : ObservableObject
{
    private readonly ILogic _logic;
    
    [ObservableProperty]
    private string _title;
    
    public string InfoText => $"Hello World from {_logic.Info.Name} by {_logic.Info.Author}";

    public string Time => DateTime.Now.ToLongTimeString();

    public IRelayCommand UpdateCommand { get; init; }

#pragma warning disable CS8618 
    public MainViewModel()
    {
        // Dummy constructor for use as designinstance in XAML Designer
        // This will never be called during execution.
        // Warnings about non-initialised fields or properties are surpressed for this constructor.
    }
#pragma warning restore CS8618

    public MainViewModel(ILogic logic)
    {
        _logic = logic;
        _title = "MainView";
        UpdateCommand = new RelayCommand(UpdateTime);
    }

    private void UpdateTime()
    {
        OnPropertyChanged(nameof(Time));
    }
}
