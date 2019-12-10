using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    public class User
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
            set { _name = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        
    }
}
