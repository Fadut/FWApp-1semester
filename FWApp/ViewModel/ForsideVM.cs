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

        private RelayCommand _skiftSideCommand;
        private ObservableCollection<User> users;
        private User _selectedUser;


        #endregion

        #region Properties

        public ObservableCollection<User> Users
        {
            get { return users; }
            set
            {
                users = value;
                OnPropertyChanged();
            }
        }

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand SkiftSideCommand
        {
            get { return _skiftSideCommand; }
            set { _skiftSideCommand = value; }
        }

        #endregion

        #region Constructor

        public ForsideVM()
        {
            SkiftSideCommand = new RelayCommand(TilFitnessGuide);
            SkiftSideCommand = new RelayCommand(TilTravlhed);
            SkiftSideCommand = new RelayCommand(TilForside);

            users = new ObservableCollection<User>();


           _selectedUser = new User("Marc");

        }

        #endregion

        #region Metoder

        public void TilFitnessGuide()
        {

        }

        public void TilTravlhed()
        {

        }

        public void TilForside()
        {

        }


        #endregion

    }
}
