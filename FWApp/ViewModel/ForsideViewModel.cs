﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWApp.Common;
using FWApp.Model;

namespace FWApp.ViewModel
{
    public class ForsideViewModel : BaseViewModel
    {

        #region Instance Fields

        private User _selectedUser;

        private ObservableCollection<Advertisement> _advertisements;
        private Catalog _adCatalog = new Catalog();

        #endregion


        #region Constructor

        public ForsideViewModel()
        {

        }

        #endregion



        public ObservableCollection<Advertisement> Advertisements
        {
            get { return _advertisements; }
            set
            {
                _advertisements = value;
                OnPropertyChanged();
            }
        }


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
