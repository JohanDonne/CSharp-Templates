using JDTemplate.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDTemplate.Presentation.ViewModels;
public class PeriodViewModel
{
    public TimePeriod TimePeriod { get; }
    public bool IsSelected { get; set; } = false;

    public PeriodViewModel(TimePeriod period)
    {
        TimePeriod= period; 
    }
}
