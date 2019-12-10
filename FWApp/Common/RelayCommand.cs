using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FWApp.Common
{
    class RelayCommand : ICommand
    {
        private Action _skiftSide;

        public RelayCommand(Action skiftSide)
        {
            _skiftSide = skiftSide;
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
