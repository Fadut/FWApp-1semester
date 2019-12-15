using FWApp.Common;
using FWApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FWApp.ViewModel
{
    class LoginViewModel : BaseVM
    {
        private RelayCommand _logindCommand;

        private User _bruger;
        private bool _rememberMe;
        public User Bruger
        {
            get { return _bruger; }
            set { _bruger = value; }
        }

        public bool RememberMe
        {
            get { return _rememberMe; }
            set { _rememberMe = value; }
        }
        public RelayCommand LogIndCommand
        {
            get { return _logindCommand; }
        }

        public LoginViewModel()
        {
            _logindCommand = new RelayCommand(LogIndMetode);
            _bruger = new User();

        }

        private async void LogIndMetode()
        {
            ObservableCollection<User> u = SharedKnowledgeSingleton.Instance.Users;
            bool fundet = u.Where(x => x.Email == _bruger.Email && x.Password == _bruger.Password).Count() > 0;

            if (fundet)
            {
                if (_rememberMe)
                {
                    ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    localSettings.Values["IsLoggenIn"] = "true";
                }
                Frame f = (Frame)Window.Current.Content;
                f.Navigate(typeof(FWApp.FrontPage));
            }
            if (!fundet)
            {
                MessageDialog md = new MessageDialog("Email eller Password er forkert.");
                await md.ShowAsync();
            }

        }

        public async void LogOutMetode()
        {
            ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["IsLoggenIn"] = null;

        }

    }
}
