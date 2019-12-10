using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWApp.Common;

namespace FWApp.ViewModel
{
    class ForsideVM
    {

        #region Instance Fields

        private RelayCommand _skiftSideCommand;


        #endregion

        #region Properties

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
