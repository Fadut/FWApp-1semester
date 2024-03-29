﻿using FWApp.Model;
using FWApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Common
{
  public  class SharedKnowledgeSingleton : BaseViewModel 
    {
        private static SharedKnowledgeSingleton _instance = new SharedKnowledgeSingleton();

        private ObservableCollection<User> _users;

        private SharedKnowledgeSingleton()
        {
            _found = new Equipment();
            User user = new User("Bruger", 4444444, "Hovedgaden 23a", "bruger@gmail.com", "abcd");
            _users = new ObservableCollection<User>();
            _users.Add(user);
        }

        public static SharedKnowledgeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SharedKnowledgeSingleton();
                }
                return _instance;
            }
        }

        private Equipment _found;
        public Equipment Found
        {
            get { return _found; }
            set 
            { 
                _found = value;
                OnPropertyChanged(nameof(Found));
            }
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

    }
    
}
