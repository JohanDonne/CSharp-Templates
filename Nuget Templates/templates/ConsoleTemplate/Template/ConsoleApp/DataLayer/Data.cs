﻿using Template.Domain.Entities;
using Template.Domain.Interfaces;

namespace Template.DataLayer;

public class Data : IData
{
    public AppInfo Info { get; } = new AppInfo { Name = "3 - Layer App (Project Folders)", CreationDate = "01/01/1901" };
}
