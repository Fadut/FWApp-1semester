using FWApp.Model;
using FWApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Common
{
  public  class SharedKnowledgeSingleton : BaseVM 
    {
        private static SharedKnowledgeSingleton _instance = new SharedKnowledgeSingleton();

        private SharedKnowledgeSingleton()
        {
            _found = new Equipment();
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
    }
    
}
