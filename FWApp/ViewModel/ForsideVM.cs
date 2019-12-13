using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWApp.Common;
using FWApp.Model;

namespace FWApp.ViewModel
{
    class ForsideVM : BaseVM
    {

        #region Instance Fields

        private User _selectedUser;

        #endregion

        #region Properties

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        #endregion




    }
}
