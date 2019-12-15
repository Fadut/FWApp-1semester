using FWApp.Common;
using FWApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FWApp.ViewModel
{
    class LoginViewModel : BaseVM
    {
        private RelayCommand _logindCommand;

        private User _bruger;

        public User Bruger
        {
            get { return _bruger; }
            set { _bruger = value; }
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
            bool fundet = false;

            foreach (var item in u)
            {
                if(item.Email==_bruger.Email)
                {
                    if(item.Password==_bruger.Password)
                    {
                        Frame f = (Frame) Window.Current.Content;
                        f.Navigate(typeof(FWApp.FrontPage));
                        fundet = true;
                    }
                }
                
            }

            if (!fundet)
            {
                MessageDialog md = new MessageDialog("Email eller Password er forkert.");
                await md.ShowAsync();
            }
            
        }
    }
}
