﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FWApp.Common
{
    public class RelayCommand : ICommand
    {
        private Action _metode;

        public RelayCommand(Action metode)
        {
            _metode = metode;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _metode();
        }

        public event EventHandler CanExecuteChanged;
    }
}
