using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JDTemplate.Domain.Entities;
using JDTemplate.Domain.Interfaces;

namespace JDTemplate.PresentationLayer.ViewModels;
public class MainViewModel : ObservableObject
{
    private readonly ILogic _logic;
    private bool _awaitingForecast = false;

    private bool AwaitingForecast
    {
        get => _awaitingForecast;
        set
        {
            _awaitingForecast = value;
            UpdateForecastCommand.NotifyCanExecuteChanged();
        }
    }

        public string InfoText => $"Hello World from {_logic.Info.Name} created on {_logic.Info.CreationDate}";

    public WeatherForecast[]? Forecast { get; private set; }

    public string Time => DateTime.Now.ToLongTimeString();

    public IAsyncRelayCommand UpdateForecastCommand { get; init; }
    public string Title { get ; private set ; }

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
        Title = "MainView";
        UpdateForecastCommand = new AsyncRelayCommand(GetForecastAsync, () => !_awaitingForecast);
        _ = GetForecastAsync();
        _ = TimeLoop();
    }

    private async Task TimeLoop()
    {
        var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(100));
        while (await timer.WaitForNextTickAsync())
        {
            OnPropertyChanged(nameof(Time));
        }
    }

    private async Task GetForecastAsync()
    {
        AwaitingForecast = true;
        Forecast = await _logic.GetForecastAsync();
        OnPropertyChanged(nameof(Forecast));
        AwaitingForecast = false;
    }
}
