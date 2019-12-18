using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    public class Profile
    {

        #region Instance Fields

        private int _fitnessNiveau;
        private int _currentXp;

        #endregion

        #region Properties

        public int FitnessNiveau
        {
            get { return _fitnessNiveau; }
            set { _fitnessNiveau = value; }
        }

        public int CurrentXp
        {
            get { return _currentXp; }
            set { _currentXp = value; }
        }

        #endregion

        


    }
}
