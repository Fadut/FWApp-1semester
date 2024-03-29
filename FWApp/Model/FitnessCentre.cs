﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    public class FitnessCentre
    {
        #region Instance fields
        private double _startHour;
        private double _endHour;
        private string _adress;
        #endregion


        #region Constructor
        public FitnessCentre(double startHour, double endHour, string adress)
        {
            _startHour = startHour;
            _endHour = endHour;
            _adress = adress;
        }
        #endregion


        #region Properties
        public double StartHour
        {
            get { return _startHour; }
            set { _startHour = value; }
        }
        public double EndHour
        {
            get { return _endHour; }
            set { _endHour = value; }
        }
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }
        #endregion 


    }
}
