﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismApp.Core.Services
{
    public interface IPrismWindowsManager
    {
        void CreateWindow<T>() where T : Window;
        void CreateModalWindow<T>() where T : Window;
        void CreateOrRestoreWindow<T>() where T : Window;
    }
}
