using JDTemplate.Core.Exceptions;
using JDTemplate.Core.Interfaces;
using JDTemplate.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Presentation;
public class ConsoleUi
{
    private readonly IAppCore _appCore;

    private TimePeriod _period = TimePeriod.Week;

    public ConsoleUi(IAppCore core)
    {
        _appCore = core;
    }

    public async Task Run()
    {

        Console.WriteLine($"Hello World from {_appCore.Info.Name} created on {_appCore.Info.CreationDate}\n");
        await SetWeekPeriod();
        bool finished = false;
        while (!finished)
        {
            char choice = GetChoice();
            switch (choice)
            {
                case 'e' or 'E' : { finished = true; break; }
                case 'u' or 'U' : { await Update(); break; }
                case 'd' or 'D' : { await SetDayPeriod(); break; }
                case 'w' or 'W' : { await SetWeekPeriod(); break; }
                case 'f' or 'F' : { await SetFortnightperiod(); break; }
                default         : { ShowHelp(); break; }
            }
        }
    }

    private static void ShowHelp()
    {
        Console.WriteLine("'U': Update ");
        Console.WriteLine("'D': Switch to period of one day");
        Console.WriteLine("'W': Switch to period of one week");
        Console.WriteLine("'F': Switch to period of a fortnight");
        Console.WriteLine("'E': Exit ");
    }

    private async Task SetFortnightperiod()
    {
        _period = TimePeriod.Fortnight;
        await Update();
    }

    private async Task SetWeekPeriod()
    {
        _period = TimePeriod.Week;
        await Update();
    }

    private async Task SetDayPeriod()
    {
        _period = TimePeriod.Day;
        await Update();
    }

    private static char GetChoice()
    {
        Console.Write("\nEnter Command (U, D, W, F, E, H for help):");
        var key = Console.ReadKey();
        Console.WriteLine("\n");
        char c = key.KeyChar;
        return c;
    }

    private async Task Update()
    {
        try
        {
            var result = await _appCore.GetForecastAsync(_period);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Date,-10} : {item.Temperature.CelsiusValue,5:F1}°C, {item.Temperature.Summary}");
            }        
        }
        catch (ForecastNotAvailableException)
        {
            Console.WriteLine("Could not retrieve forecast!  Try again...");
        }
    }
}
