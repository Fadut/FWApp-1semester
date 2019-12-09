using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Assets.Model
{
    class UserClass
    {
        #region Instance Fields

        private string _name;

        private int _phoneNumber;

        private string _address;

        private string _email;

        private string _password;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Email
        {
            get { return _email; }
        }
        
        public string Password
        {
            get { return _password; }
        }

        #endregion

        //
    }
}
