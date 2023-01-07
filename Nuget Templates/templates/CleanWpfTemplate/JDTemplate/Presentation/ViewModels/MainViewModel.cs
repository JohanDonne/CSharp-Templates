using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using JDTemplate.Core.Exceptions;
using JDTemplate.Core.Interfaces;
using JDTemplate.Core.Models;
using JDTemplate.Domain.Enums;

namespace JDTemplate.Presentation.ViewModels;
public class MainViewModel : ObservableObject
{
    private readonly IAppCore _appCore;
    private bool _awaitingForecast = false;
    private bool _forecastError = false;

    private bool AwaitingForecast
    {
        get => _awaitingForecast;
        set
        {
            _awaitingForecast = value;
            UpdateForecastCommand.NotifyCanExecuteChanged();
        }
    }

    public string InfoText => $"Hello World from {_appCore.Info.Name} created on {_appCore.Info.CreationDate}";

    public WeatherForecast[]? Forecast { get; private set; }

    public string Time => DateTime.Now.ToLongTimeString();

    public IAsyncRelayCommand UpdateForecastCommand { get; init; }

    public IRelayCommand<TimePeriod> ChangePeriodCommand { get; init; }
    public string Title { get; set; }

    public PeriodViewModel[]? Periods { get; private set; }
    public bool ForecastError  { get => _forecastError;  set => SetProperty(ref _forecastError, value); }

#pragma warning disable CS8618
    public MainViewModel()
    {
        // Dummy constructor for use as designinstance in XAML Designer
        // This will never be called during execution.
        // Warnings about non-initialised fields or properties are surpressed for this constructor.
    }
#pragma warning restore CS8618

    public MainViewModel(IAppCore core)
    {
        _appCore = core;
        Title = "MainView";
        InitPeriodViewModels();
        UpdateForecastCommand = new AsyncRelayCommand(GetForecastAsync, () => !_awaitingForecast);
        ChangePeriodCommand = new RelayCommand<TimePeriod>(ChangePeriod);
        _ = GetForecastAsync();
        _ = TimeLoop();
    }

    private void ChangePeriod(TimePeriod period)
    {
        foreach (var item in Periods!)
        {
            item.IsSelected = period == item.TimePeriod;
        };
        _ = GetForecastAsync();
    }

    private void InitPeriodViewModels()
    {
        Periods = ((TimePeriod[])Enum.GetValues(typeof(TimePeriod))).Select((p) => new PeriodViewModel(p)).ToArray();
        if (Periods.Length > 0) Periods[0].IsSelected = true;
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
        ForecastError = false;
        var period = Periods!.First((p) => p.IsSelected).TimePeriod;
        Forecast = Array.Empty<WeatherForecast>();
        try
        {
            Forecast = await _appCore.GetForecastAsync(period);
        }
        catch (ForecastNotAvailableException)
        { 
            ForecastError= true;
        }
        OnPropertyChanged(nameof(Forecast));
        AwaitingForecast = false;
    }
}
