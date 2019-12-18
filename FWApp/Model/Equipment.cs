using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    public class Equipment
    {


        #region Instance fields
        private int _iD;
        private string _name;
        private string _muscleGroup;
        private string _description;
        private string _video;

        #endregion


        #region Constructor
        public Equipment() { }
        public Equipment(int iD, string name, string muscleGroup, string description, string video)
        {
            _iD = iD;
            _name = name;
            _muscleGroup = muscleGroup;
            _description = description;
            _video = video;
        }

        #endregion


        #region Properties
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string MuscleGroup
        {
            get { return _muscleGroup; }
            set { _muscleGroup = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Video
        {
            get { return _video; }
            set { _video = value; }
        }


        #endregion


        #region Methods
        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(Name)}: {Name}, {nameof(MuscleGroup)}: {MuscleGroup}, {nameof(Description)}: {Description}, {nameof(Video)}: {Video}";
        }

        #endregion




    }
}
